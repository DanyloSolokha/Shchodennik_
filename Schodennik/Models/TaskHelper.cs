using Schodennik;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using static System.Runtime.InteropServices.JavaScript.JSType;

public static class TaskHelper
{
    public static Task CreateAndAddTask(string description, string note, string location, int startHour, int startMinute, int duration, DateTime date, List<Task> exceptionList = null)
    {
        Task task = new Task(startHour, startMinute, duration, date);
        SetTaskProperties(task, description, note, location);
        if (AddTaskToHolder(task, exceptionList))
        {
            return task;
        }
        return null;
    }

    public static List<RepTask> CreateAndAddRepTaskChain(string description, string note, string location, int startHour, int startMinute, int duration, DateTime date, DateTime endDate, int frequency, List<Task> exceptionList = null)
    {
        List<RepTask> repTaskList = RepTask.CreateRepTaskList(startHour, startMinute, duration, date, endDate, frequency);
        foreach(var task in repTaskList) SetRepTaskProperties(task, description, note, location);
        if (AddRepTaskChainToHolder(repTaskList, exceptionList))
        {
            return repTaskList;
        }
        return null;
    }

    private static void SetTaskProperties(Task task, string description, string note, string location)
    {
        if (description.Length > 0) task.Description = description;
        if (note.Length > 0) task.Note = note;
        if (location.Length > 0) task.Location = location;
    }

    private static void SetRepTaskProperties(RepTask task, string description, string note, string location)
    {
        if (description.Length > 0) task.Description = description;
        if (note.Length > 0) task.Note = note;
        if (location.Length > 0) task.Location = location;
    }

    public static List<Task> GetCrossingTasks(int startHour, int startMinute, int duration, List<Task> allTasks)
    {
        List<Task> crossingTasks = new List<Task>();
        int absoluteStartTime = startHour * 60 + startMinute;
        int endTime = absoluteStartTime + duration;

        foreach (Task t in allTasks)
        {
            if (endTime > t.AbsoluteStartTime && absoluteStartTime < t.EndTime)
            {
                crossingTasks.Add(t);
            }
        }

        return crossingTasks;
    }



    public static bool AddTaskToHolder(Task task, List<Task> exceptionList = null)
    {
        try
        {
            if (task.Duration < 10) throw new ArgumentException("замала продовжність.");
            if (!task.CheckFit()) throw new ArgumentException("задача не входить в межі доби.");

            if (!task.TaskTest(exceptionList)) throw new Exception("задача перетинається з іншими.");

            task.AddToHolder();
            return true;
        }
        catch (ArgumentException aex)
        {
            MessageBox.Show(aex.Message, "помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        catch (Exception)
        {
            return HandleTaskConflict(task);
        }
    }

    public static bool AddRepTaskChainToHolder(List<RepTask> taskList, List<Task> exceptionList = null)
    {

        try
        {
            if (taskList.Count == 0 || taskList == null) throw new ArgumentException("Не можна щоб дата кінця була менша за дату початку");
        }
        catch (ArgumentException aex)
        {
            MessageBox.Show(aex.Message, "помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        foreach (var task in taskList)
        {
            try
            {
                if (task.Duration < 10) throw new ArgumentException("тривалість задачі має бути не менше 10 хвилин.");
                if (!task.CheckFit()) throw new ArgumentException("задача не вкладається в межі доби.");
                if (!task.TaskTest(exceptionList)) throw new Exception("Задача перетинається з іншими.");
            }
            catch (ArgumentException aex)
            {
                MessageBox.Show(aex.Message, "помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception)
            {
                return HandleRepTaskChainConflict(taskList);
            }
        }

        foreach (var task in taskList)
        {
            task.AddToHolder();
        }

        return true;
    }

    private static bool HandleTaskConflict(Task task)
    {
        int newStartTime = UniversalHelper.FindNearestAvailableTime(task, task.AbsoluteStartTime, task.Duration, task.Date);
        if (newStartTime != -1)
        {
            DialogResult result1 = MessageBox.Show(
                $"Задача перетинаєтсья з іншою. Найближчий доступний час: {newStartTime / 60:D2}:{newStartTime % 60:D2}. Хочете перенести на цей час?",
                "Перетин задач", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                task.AbsoluteStartTime = newStartTime;
                task.AddToHolder();
                return true;
            }
        }
        else
        {
            MessageBox.Show(
                "Задача перетинаєтсья з іншою.",
                "Перетин задач", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        return false;
    }

    private static bool HandleRepTaskChainConflict(List<RepTask> taskList)
    {
        List<RepTask> failedTestList = new List<RepTask>();

        foreach (var task in taskList)
        {
            if (!task.TaskTest())
            {
                failedTestList.Add(task);
            }
        }

        int newStartTime = -1;

        foreach (var task in failedTestList)
        {
            newStartTime = UniversalHelper.FindNearestAvailableTime(task, task.AbsoluteStartTime, task.Duration, task.Date);
            if (newStartTime != -1) break;
        }


        if (newStartTime != -1)
        {
            DialogResult result1 = MessageBox.Show(
                "Одна або декілька задач перетинається з іншими. Перенести їх на найближчий можливий час?",
                "Перетин задач", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                foreach (var task in taskList)
                {
                    newStartTime = UniversalHelper.FindNearestAvailableTime(task, task.AbsoluteStartTime, task.Duration, task.Date);
                    task.AbsoluteStartTime = newStartTime;
                    task.AddToHolder();
                }
                return true;
            }
        }
        else
        {
            MessageBox.Show(
                "Одна або декілька задач перетинається з іншими. Спробуйте інший час або перенесіть/видаліть задачі, що перетинаються",
                "перетин задач", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        return false;
    }

    public static void RescheduleTask(Task task, int startHour, int startMinute, int duration, DateTime date, List<Task> exceptionList = null)
    {
        if (!Task.CheckFit(startHour, startMinute, duration))
        {
            throw new ArgumentException("задача не вкладається в межі доби");
        }

        if (exceptionList == null) exceptionList = new List<Task>();
        exceptionList.Add(task);

        List<Task> allTasks = DataHolder.AllExceptThis(date, exceptionList);
        List<Task> crossingTasks = TaskHelper.GetCrossingTasks(startHour, startMinute, duration, allTasks);

        if (crossingTasks.Count > 0)
        {
            throw new Exception("задача перетинається з іншими");
        }

        //якщо не було помилок периносимо

        task.StartHour = startHour;
        task.StartMinute = startMinute;
        task.Duration = duration;

        if (date != task.Date)
        {
            task.RemoveFromHolder();
            task.Date = date;
            task.AddToHolder();

        }

        DataHolder.UpdateTaskCollections();
    }

    public static bool UpdateTasksChain(RepTask firstTaskInChain, DateTime newLastDate, int newFrequency, int startHour, int startMinute, int duration, DateTime date)
    {

        List<RepTask> testList = RepTask.CreateRepTaskList(startHour, startMinute, duration, date, newLastDate, newFrequency);
        List<RepTask> allForward = firstTaskInChain.ThisAndAllSubsequentTasks;

        List<Task> exceptionList = new List<Task>(allForward);

        try
        {
            if (newLastDate < date) throw new ArgumentException("Не можна щоб дата кінця була менша за дату початку");
            if (testList.Count == 1) throw new ArgumentException("одна справа у списку повторюваних");
        }
        catch (ArgumentException aex)
        {
            MessageBox.Show(aex.Message, "помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        foreach (var task in testList)
        {
            try
            {
                if (task.Duration < 10) throw new ArgumentException("Не можна запланувати задачу з тривалістю менше 10 хв.");
                if (!task.CheckFit()) throw new ArgumentException("задача не вкладається в межі доби.");
                if (!task.TaskTest(exceptionList)) throw new Exception("задача перетинається з іншими.");
            }
            catch (ArgumentException aex)
            {
                MessageBox.Show(aex.Message, "помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception)
            {
                return HandleRepTaskChainReTakeConflict(firstTaskInChain, newLastDate, newFrequency, startHour, startMinute, duration,  date, testList);
            }
        }

        //якщо не трапилося помилок або перетину задач

        if (testList.Count != allForward.Count)
        {
            DialogResult result2 = MessageBox.Show(
                "Доведеться додати/видалити декілька задач. Продовжити?",
                "Зміна кількості задач у ланцюгу",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result2 == DialogResult.Yes)
            {
                if (firstTaskInChain.ThisAndAllSubsequentTasks.Count < testList.Count)
                {
                    
                    RepTask current = firstTaskInChain.LastInChain;
                    current.Date = date;

                    //додаємо 
                    while (testList.Count > firstTaskInChain.ThisAndAllSubsequentTasks.Count)
                    {
                        RepTask n = new RepTask(current.StartHour, current.StartMinute, current.Duration, current.Date);
                        n.UpdateBasicProperty(firstTaskInChain.Description, firstTaskInChain.Note, firstTaskInChain.Location);

                        current.Next = n;
                        current.NextId = n.Id;

                        n.Prev = current;
                        n.PrevId = current.Id;

                        current = n;
                        n.AddToHolder();
                    }
                    

                }
                else if (firstTaskInChain.ThisAndAllSubsequentTasks.Count > testList.Count)
                {
                    RepTask current = firstTaskInChain.LastInChain;

                    while (testList.Count < firstTaskInChain.ThisAndAllSubsequentTasks.Count)
                    {
                        current = current.Prev;

                        current.Next.RemoveFromHolder();
                        current.Next.DisapearFromChain();
                    }
                }
                foreach (var t in firstTaskInChain.ThisAndAllSubsequentTasks) t.Frequency = newFrequency;
            }
            else
            {
                return false;
            }
        }

        List<RepTask> newAllForward = firstTaskInChain.ThisAndAllSubsequentTasks;
        exceptionList = new List<Task>(newAllForward);

        firstTaskInChain.BreackChain();

        RepTask crnt = firstTaskInChain;


        if (crnt != null)
        {
            for (DateTime i = date; i <= newLastDate; i = i.AddDays(newFrequency))
            {
                Task.ReSchedule(crnt, startHour, startMinute, duration, i, exceptionList);
                crnt = crnt.Next;
            }
        }

        DataHolder.UpdateTaskCollections();

        return true;
    }

    private static bool HandleRepTaskChainReTakeConflict(RepTask firstTaskInChain, DateTime newLastDate, int newFrequency, int startHour, int startMinute, int duration, DateTime date, List<RepTask> testList)
    {

        List<RepTask> failedTestList = new List<RepTask>();

        List<RepTask> allForward = firstTaskInChain.ThisAndAllSubsequentTasks;

        List<Task> exceptionList = new List<Task>(allForward);

        foreach (var task in testList)
        {
            if (!task.TaskTest(exceptionList))
            {
                failedTestList.Add(task);
            }
        }

        int newStartTime = -1;

        foreach (var task in failedTestList)
        {
            newStartTime = UniversalHelper.FindNearestAvailableTime(task, startMinute + startHour * 60, duration, task.Date, exceptionList);
            if (newStartTime != -1) break;
        }

        if (newStartTime != -1)
        {
            DialogResult result1 = MessageBox.Show(
                "Одна або декілька задач перетинається з іншими. Перенести їх на найближчий можливий час?",
                "Перетин задач", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {

                if (testList.Count != allForward.Count)
                {
                    DialogResult result2 = MessageBox.Show(
                        "Доведеться додати/видалити декілька задач. Продовжити?",
                        "Зміна кількості задач у ланцюгу", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result2 == DialogResult.Yes)
                    {
                        if (firstTaskInChain.ThisAndAllSubsequentTasks.Count < testList.Count)
                        {
                            RepTask current = firstTaskInChain.LastInChain;
                            current.Date = date;

                            while (testList.Count > firstTaskInChain.ThisAndAllSubsequentTasks.Count)
                            {
                                RepTask n = new RepTask(current.StartHour, current.StartMinute, current.Duration, current.Date);
                                n.UpdateBasicProperty(firstTaskInChain.Description, firstTaskInChain.Note, firstTaskInChain.Location);

                                current.Next = n;
                                current.NextId = n.Id;

                                n.Prev = current;
                                n.PrevId = current.Id;

                                current = n;
                                n.AddToHolder();
                            }

                        }
                        else if (firstTaskInChain.ThisAndAllSubsequentTasks.Count > testList.Count)
                        {
                            RepTask current = firstTaskInChain.LastInChain;

                            while (testList.Count < firstTaskInChain.ThisAndAllSubsequentTasks.Count)
                            {
                                current = current.Prev;
                                current.Next.RemoveFromHolder();
                                current.Next.DisapearFromChain();
                            }
                        }
                        foreach (var t in firstTaskInChain.ThisAndAllSubsequentTasks) t.Frequency = newFrequency;
                    }
                    else
                    {
                        return false;
                    }

                }

                List<RepTask> newAllForward = firstTaskInChain.ThisAndAllSubsequentTasks;
                exceptionList = new List<Task>(newAllForward);

                firstTaskInChain.BreackChain();

                RepTask crnt = firstTaskInChain;

                if (crnt != null)
                {
                    for (DateTime i = date; i <= newLastDate; i = i.AddDays(newFrequency))
                    {
                        int newAbsoluteStartTime = UniversalHelper.FindNearestAvailableTime(crnt, startMinute + startHour * 60, duration,i, exceptionList);

                        int newStartHour = newAbsoluteStartTime / 60;
                        int newStartMinute = newAbsoluteStartTime % 60;

                        Task.ReSchedule(crnt, newStartHour, newStartMinute, duration, i, exceptionList);
                        crnt = crnt.Next;
                    }
                }
                DataHolder.UpdateTaskCollections();

                return true;
            }
        }
        else
        {
            MessageBox.Show(
                $"Одна або декілька задач перетинається з іншими. Спробуйте інший час або перенесіть/видаліть задачі, що перетинаються",
                "Перетин задач", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        return false;
    }

    public static void CheckOneForward(RepTask repTask)
    {
        List<RepTask> allForwardExceptThis = repTask.AllSubsequentTasks;
        if (allForwardExceptThis.Count == 1)
        {
            RepTask oneAndOnly = allForwardExceptThis[0];
            Task newTask = oneAndOnly.ReturnCopyTask();

            oneAndOnly.RemoveFromHolder();
            newTask.AddToHolder();
        }
    }

    public static void CheckOnePrev(RepTask repTask)
    {
        List<RepTask> allPrev = repTask.AllPreviousTasks;
        if (allPrev.Count == 1)
        {
            RepTask oneAndOnly = allPrev[0];
            Task newTask = oneAndOnly.ReturnCopyTask();

            oneAndOnly.RemoveFromHolder();
            newTask.AddToHolder();
        }
    }

    //rep => ...
    public static void UpdateRep(RepTask repTask, string description, string note, string location, bool done, int startHour, int startMinute, int duration, DateTime date, DateTime endDate, int frequency)
    {
        if (frequency <= 0)
        {
            MessageBox.Show("частота має бути більша за 0", "помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            using (SelectModeForm form = new SelectModeForm("тільки цю", "всі наступні (тільки час)", "всі наступні (зміст і час)", "всі наступні (тільки зміст)"))
            {
                if (repTask.AllSubsequentTasks.Count == 0)
                {
                    form.SecondModeButton.Enabled = false;
                    form.ThirdModeButton.Enabled = false;
                    form.FourthModeButton.Enabled = false;
                }
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (form.SelectedMode == SelectModeForm.RescheduleMode.firstMode)
                    {
                        //тільки цю
                        if (repTask.Date != date)
                        {
                            DialogResult res = MessageBox.Show("якщо перенести повторювану справу на інший день, то її доведеться прибрати із списка повторюваних. Продовжити?", "попередження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (res == DialogResult.Yes)
                            {
                                Task newTask = TaskHelper.CreateAndAddTask(description, note, location, startHour, startMinute, duration, date);

                                if (newTask != null)
                                {
                                    TaskHelper.CheckOnePrev(repTask);
                                    TaskHelper.CheckOneForward(repTask);

                                    repTask.RemoveFromHolder();
                                    repTask.DisapearFromChain();
                                    newTask.Done = done;
                                }
                            }
                        }
                        else
                        {
                            Task.ReSchedule(repTask, startHour, startMinute, duration, date);

                            repTask.UpdateBasicProperty(description, note, location);
                            repTask.Done = done;
                        }

                    }
                    else if (form.SelectedMode == SelectModeForm.RescheduleMode.secondMode)
                    {
                        //усі наступні (тільки час)

                        DateTime newLastDate = endDate;

                        int newFrequency = frequency;

                        TaskHelper.UpdateTasksChain(repTask, newLastDate, newFrequency, startHour, startMinute, duration, date);

                        repTask.Done = done;

                    }
                    else if (form.SelectedMode == SelectModeForm.RescheduleMode.thirdMode)
                    {

                        //усі наступні (час і зміст)
                        DateTime newLastDate = endDate;

                        int newFrequency = frequency;

                        bool res = TaskHelper.UpdateTasksChain(repTask, newLastDate, newFrequency, startHour, startMinute, duration, date);

                        if (res)
                        {
                            List<RepTask> allFroward = repTask.ThisAndAllSubsequentTasks;

                            foreach (var t in allFroward)
                            {
                                t.UpdateBasicProperty(description, note, location);
                            }
                        }

                        repTask.Done = done;

                    }
                    else if (form.SelectedMode == SelectModeForm.RescheduleMode.fourthMode)
                    {
                        //усі наступні (тільки зміст)
                        List<RepTask> allFroward = repTask.ThisAndAllSubsequentTasks;

                        foreach (var t in allFroward)
                        {
                            t.UpdateBasicProperty(description, note, location);
                        }

                        repTask.Done = done;
                    }
                }
            }

        }
    }

    public static void RepToTask(RepTask repTask, string description, string note, string location, bool done, int startHour, int startMinute, int duration, DateTime date)
    {
        Task task = TaskHelper.CreateAndAddTask(description, note, location, startHour, startMinute, duration, date, new List<Task> { repTask });
        if (task != null)
        {
            repTask.DisapearFromChain();
            repTask.RemoveFromHolder();
            task.Done = done;
        }
    }

    public static void RepToBasicTask(RepTask task, string description, string note, string location, bool done)
    {
        task.DisapearFromChain();
        task.RemoveFromHolder();

        BasicTask bt = new BasicTask();
        bt.UpdateBasicProperty(description, note, location);
        bt.Done = done;
        bt.AddToHolder();
    }

    //task => ...

    public static void TaskToRep(Task task, string description, string note, string location, bool done, int startHour, int startMinute, int duration, DateTime date, DateTime endDate, int frequency)
    {
        List<RepTask> list = TaskHelper.CreateAndAddRepTaskChain(description, note, location, startHour, startMinute, duration, date, endDate, frequency, new List<Task>() { task });

        if (list != null)
        {
            task.RemoveFromHolder();
            list.FirstOrDefault().Done = done;
        }
    }

    public static void UpdateTask(Task task, string description, string note, string location, bool done, int startHour, int startMinute, int duration, DateTime date)
    {
        bool res = Task.ReSchedule(task, startHour, startMinute, duration, date);

        if (res)
        {
            task.UpdateBasicProperty(description, note, location);
            task.Done = done;
        }


    }

    public static void TaskToBasicTask(Task task, string description, string note, string location, bool done)
    {
        BasicTask bt = new BasicTask();

        bt.UpdateBasicProperty(description, note, location);
        bt.Done = done;

        task.RemoveFromHolder();
        bt.AddToHolder();
    }

    //bt => ...

    public static void BasicTaskToRep(BasicTask bt, string description, string note, string location, bool done, int startHour, int startMinute, int duration, DateTime date, DateTime endDate, int frequency)
    {
        List<RepTask> list = TaskHelper.CreateAndAddRepTaskChain(description, note, location, startHour, startMinute, duration, date, endDate, frequency);
        if (list != null)
        {
            bt.RemoveFromHolder();
            list.FirstOrDefault().Done = done;
        }
    }

    public static void BasicTaskToTask(BasicTask bt, string description, string note, string location, bool done, int startHour, int startMinute, int duration, DateTime date)
    {
        Task task = TaskHelper.CreateAndAddTask(description, note, location, startHour, startMinute, duration, date);
        if (task != null)
        {
            bt.RemoveFromHolder();
            task.Done = done;
        }
    }

    public static void UpdateBasicTask(BasicTask bt, string description, string note, string location, bool done)
    {
        bt.UpdateBasicProperty(description, note, location);
        bt.Done = done;
    }

}

using Schodennik;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

public static class DataHolder
{

    private static BindingList<BasicTask> basicTaskList;
    public static BindingList<BasicTask> BasicTaskList
    {
        get => basicTaskList;
        set
        {
            basicTaskList = value;
        }
    }

    private static Dictionary<DateTime, List<Task>> taskDictionary;
    public static Dictionary<DateTime, List<Task>> TaskDictionary
    {
        get => taskDictionary;
        set
        {
            taskDictionary = value;
        }
    }

    private static Dictionary<DateTime, List<RepTask>> repTaskDictionary;
    public static Dictionary<DateTime, List<RepTask>> RepTaskDictionary
    {
        get => repTaskDictionary;
        set
        {
            repTaskDictionary = value;
        }
    }

    private static List<Task> todayTasks = new List<Task>();
    private static List<Task> tomorrowTasks = new List<Task>();

    public static List<Task> TodayTasks => todayTasks;
    public static List<Task> TomorrowTasks => tomorrowTasks;

    public static void UpdateTaskCollections()
    {
        DateTime today = DateTime.Today;
        DateTime tomorrow = today.AddDays(1);

        todayTasks = AllTaskInDate(today).Where(t => t.AbsoluteStartTime >= 0).ToList();
        tomorrowTasks = AllTaskInDate(tomorrow).Where(t => t.AbsoluteStartTime < 5).ToList();
    }

    public static void EnsureDateExistsInDictionary(DateTime date)
    {
        if (!IsInitialized(TaskDictionary)) throw new Exception("колекція не ініціалізована");
        if (TaskDictionary.ContainsKey(date)) return;
        TaskDictionary[date] = new List<Task>();
    }

    public static void EnsureDateExistsInRepDictionary(DateTime date)
    {
        if (!IsInitialized(RepTaskDictionary)) throw new Exception("колекція не ініціалізована");
        if (RepTaskDictionary.ContainsKey(date)) return;
        RepTaskDictionary[date] = new List<RepTask>();
    }

    public static List<Task> AllTaskInDate(DateTime date)
    {
        List<Task> all = new List<Task>();

        List<Task> taskList = null;
        List<RepTask> repTaskList = null;

        if (DataHolder.DateInDictionary(DataHolder.TaskDictionary, date)) taskList = DataHolder.TaskDictionary[date];
        if (DataHolder.DateInDictionary(DataHolder.RepTaskDictionary, date)) repTaskList = DataHolder.RepTaskDictionary[date];

        if (taskList != null && taskList.Count > 0) all.AddRange(taskList);
        if (repTaskList != null && repTaskList.Count > 0) all.AddRange(repTaskList);

        return all;
    }

    public static bool IsInitialized<T>(T collection)
    {
        return collection != null;
    }

    public static bool DateInDictionary<T>(Dictionary<DateTime, T> dictionary, DateTime date)
    {
        if (!IsInitialized(dictionary)) throw new Exception("колекція не ініціалізована");

        return dictionary.ContainsKey(date);
    }
    public static int GetDayStat(DateTime date)
    {
        int completedTasks = 0;
        List<Task> tasks = AllTaskInDate(date);

        foreach (var task in tasks)
        {
            if (task.Done)
            {
                completedTasks++;
            }
            foreach (var subTask in task.SubTasks)
            {
                if (subTask.Done)
                {
                    completedTasks++;
                }
            }
        }

        return completedTasks;
    }

    public static int GetWeekStat(DateTime date)
    {
        int res = 0;
        DateTime current = UniversalHelper.GetMondayDate(date);

        for (int i = 0; i < 7; i++)
        {
            res += GetDayStat(current);
            current = current.AddDays(1);
        }
        return res;
    }

    public static int GetMonthStat(DateTime date)
    {
        int res = 0;
        DateTime current = UniversalHelper.GetFirstDayOfMonth(date);
        DateTime afterLast = UniversalHelper.GetFirstDayOfMonth(date.AddMonths(1));

        while (current < afterLast)
        {
            res += GetDayStat(current);
            current = current.AddDays(1);
        }

        return res;
    }

    public static int GetYearStat(DateTime date)
    {
        int res = 0;
        DateTime current = new DateTime(date.Year, 1, 1);
        DateTime nextYear = new DateTime(date.Year + 1, 1, 1);

        while (current < nextYear)
        {
            res += GetDayStat(current);
            current = current.AddDays(1);
        }

        return res;
    }

    public static List<Task> AllExceptThis(DateTime date, List<Task> exceptionList)
    {
        List<Task> allTasks = DataHolder.AllTaskInDate(date);
        List<Task> filteredTasks = allTasks.Where(task => !exceptionList.Contains(task)).ToList();

        List<Task> copiedTasks = new List<Task>();
        foreach (var task in filteredTasks)
        {
            if (task is RepTask repTask)
            {
                copiedTasks.Add(repTask.DeepCopy());
            }
            else
            {
                copiedTasks.Add(task.DeepCopy());
            }
        }

        return copiedTasks;
    }

    public static List<BasicTask> GetAllCompletedBasicTasks()
    {
        List<BasicTask> completedTasks = new List<BasicTask>();

        foreach (BasicTask task in BasicTaskList)
        {
            if (task.Done)
            {
                completedTasks.Add(task);
            }
        }

        return completedTasks;
    }

    public static List<BasicTask> GetAllIncompleteBasicTasks()
    {
        List<BasicTask> incompleteTasks = new List<BasicTask>();

        foreach (BasicTask task in BasicTaskList)
        {
            if (!task.Done)
            {
                incompleteTasks.Add(task);
            }
        }

        return incompleteTasks;
    }
}

using Schodennik;
using System;
using System.Security.Cryptography.X509Certificates;

public class Task : BasicTask
{

    public Task() { }
    public Task(int startHour, int startMinute, int duration, DateTime date)
    {
        StartHour = startHour;
        StartMinute = startMinute;
        Duration = duration;
        Date = date.Date;
    }

    public Task(int absoluteStartTime, int endTime, DateTime date)
    {
        AbsoluteStartTime = absoluteStartTime;
        Duration = endTime - absoluteStartTime;
        this.Date = date.Date;
    }

    public virtual bool TaskTest(List<Task> exceptionList = null)
    {

        int startHour = this.StartHour;
        int startMinute = this.StartMinute;
        int duration = this.Duration;
        DateTime date = this.Date;

        if (exceptionList == null) exceptionList = new List<Task>();

        exceptionList.Add(this);

        List<Task> all = DataHolder.AllExceptThis(date, exceptionList);

        List<Task> crossingTasks = TaskHelper.GetCrossingTasks(startHour, startMinute, duration, all);

        return crossingTasks.Count == 0;
    }


    private DateTime _date = default;
    public DateTime Date
    {
        get { return _date; }
        set
        {
            this._date = value;
        }
    }

    private int _duration;
    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }

    private int _absoluteStartTime;
    public int AbsoluteStartTime
    {
        get { return _absoluteStartTime; }
        set
        {
            if (value < 0 || value >= 1440)
            {
                MessageBox.Show("початковий час має бути не більше 23:59 і не менше 00:00", "помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _absoluteStartTime = value;
            }

        }
    }

    public int StartHour
    {
        get
        {
            return (int)Math.Floor((double)AbsoluteStartTime / 60);
        }
        set
        {
            if (value < 0 || value >= 24)
            {
                MessageBox.Show("значення години повинно бути від 0 до 23.", "помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AbsoluteStartTime = value * 60 + StartMinute;
            }
        }
    }

    public int StartMinute
    {
        get
        {
            return AbsoluteStartTime % 60;
        }
        set
        {
            if (value < 0 || value >= 60)
            {
                MessageBox.Show("значення хвилин повинно бути від 0 до 59.");
            }
            else
            {
                AbsoluteStartTime = value + StartHour * 60;
            }
        }
    }

    public int EndTime
    {
        get
        {
            return AbsoluteStartTime + Duration;
        }
    }

    public virtual void AddToHolder()
    {
        DataHolder.EnsureDateExistsInDictionary(this.Date);
        DataHolder.TaskDictionary[this.Date].Add(this);
        DataHolder.UpdateTaskCollections();
    }

    public virtual void RemoveFromHolder()
    {
        if (DataHolder.DateInDictionary(DataHolder.TaskDictionary, this.Date))
        {
            DataHolder.TaskDictionary[this.Date].Remove(this);
        }
        else
        {
            throw new Exception("видалення проблемне");
        }

        DataHolder.UpdateTaskCollections();
    }

    public bool CheckFit()
    {
        return this.AbsoluteStartTime + this.Duration <= 1440;
    }

    public static bool CheckFit(int startHour, int startMinute, int duration)
    {
        return 1440 >= startHour * 60 + startMinute + duration;
    }

    public static bool ReSchedule(Task task, int startHour, int startMinute, int duration, DateTime date, List<Task> exceptionList = null)
    {
        try
        {
            TaskHelper.RescheduleTask(task, startHour, startMinute, duration, date, exceptionList);

            return true;
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        catch (Exception ex)
        {
            if (ex.Message.Contains("задача перетинається з іншими"))
            {
                MessageBox.Show("задача перетинається з іншими, спробуйте інший час або перенесіть/видаліть задачі, котрі перетинаються", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
        return false;
    }

    public new Task DeepCopy()
    {
        Task copy = new Task(AbsoluteStartTime, EndTime, Date)
        {
            Description = this.Description,
            Note = this.Note,
            Location = this.Location,
            Done = this.Done
        };

        foreach (var subTask in this.SubTasks)
        {
            copy.AddSubTask(subTask.DeepCopy());
        }

        return copy;
    }
}
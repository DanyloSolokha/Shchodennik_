using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Schodennik
{
    public class RepTask : Task
    {
        public RepTask()
        {
            Id = Guid.NewGuid();
        }

        [JsonIgnore]
        private RepTask _next = null;

        [JsonIgnore]
        public RepTask Next
        {
            get { return _next; }
            set { _next = value; }
        }

        [JsonIgnore]
        private RepTask _prev = null;

        [JsonIgnore]
        public RepTask Prev
        {
            get { return this._prev; }
            set { _prev = value; }
        }

        public int Frequency { get; set; }

        public Guid Id { get; set; }

        [JsonPropertyName("NextId")]
        public Guid? NextId { get; set; }

        [JsonPropertyName("PrevId")]
        public Guid? PrevId { get; set; }

        public RepTask(int startHour, int startMinute, int duration, DateTime date) : base(startHour, startMinute, duration, date)
        {
            Id = Guid.NewGuid();
        }

        public RepTask(int absoluteStartTime, int endTime, DateTime date) : base(absoluteStartTime, endTime, date)
        {
            Id = Guid.NewGuid();
        }

        public static List<RepTask> CreateRepTaskList(int startHour, int startMinute, int duration, DateTime date, DateTime endDate, int frequency)
        {
            List<RepTask> list = new List<RepTask>();

            RepTask previousTask = null;

            for (DateTime currentDate = date; currentDate <= endDate; currentDate = currentDate.AddDays(frequency))
            {
                RepTask repTask = new RepTask(startHour, startMinute, duration, currentDate);
                repTask.Frequency = frequency;
                list.Add(repTask);

                if (previousTask != null)
                {
                    previousTask.Next = repTask;
                    repTask.Prev = previousTask;
                    previousTask.NextId = repTask.Id;
                    repTask.PrevId = previousTask.Id;
                }

                previousTask = repTask;
            }

            return list;
        }

        public override void AddToHolder()
        {
            DataHolder.EnsureDateExistsInRepDictionary(this.Date);
            DataHolder.RepTaskDictionary[this.Date].Add(this);
            DataHolder.UpdateTaskCollections();
        }

        public override void RemoveFromHolder()
        {
            if (DataHolder.DateInDictionary(DataHolder.RepTaskDictionary, this.Date))
            {
                DataHolder.RepTaskDictionary[this.Date].Remove(this);
            }
            else
            {
                throw new Exception("видалення проблемне");
            }
            DataHolder.UpdateTaskCollections();
        }

        public void DisapearFromChain()
        {
            if (this.Prev != null)
            {
                this.Prev.Next = null;
                this.Prev.NextId = null;
            }
            if (this.Next != null)
            {
                this.Next.Prev = null;
                this.Next.PrevId = null;
            }

            this.Prev = null;
            this.Next = null;
        }

        public void BreackChain()
        {
            if (this.Prev != null)
            {
                this.Prev.Next = null;
                this.Prev.NextId = null;

                this.Prev = null;
                this.PrevId = null;
            }
        }

        [JsonIgnore]
        public RepTask FirstInChain
        {
            get
            {
                RepTask first = this;
                while (first.Prev != null)
                {
                    first = first.Prev;
                }
                return first;
            }
        }

        [JsonIgnore]
        public RepTask LastInChain
        {
            get
            {
                RepTask last = this;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                return last;
            }
        }

        [JsonIgnore]
        public DateTime FirstDate
        {
            get
            {
                return FirstInChain.Date;
            }
        }

        [JsonIgnore]
        public DateTime LastDate
        {
            get
            {
                return LastInChain.Date;
            }
        }

        [JsonIgnore]
        public List<RepTask> ThisAndAllSubsequentTasks
        {
            get
            {
                List<RepTask> tasks = new List<RepTask>();
                RepTask currentTask = this;

                while (currentTask != null)
                {
                    tasks.Add(currentTask);
                    currentTask = currentTask.Next;
                }

                return tasks;
            }
        }

        [JsonIgnore]
        public List<RepTask> AllSubsequentTasks
        {
            get
            {
                List<RepTask> tasks = new List<RepTask>();
                RepTask currentTask = this.Next;

                while (currentTask != null)
                {
                    tasks.Add(currentTask);
                    currentTask = currentTask.Next;
                }

                return tasks;
            }
        }

        [JsonIgnore]
        public List<RepTask> AllPreviousTasks
        {
            get
            {
                List<RepTask> tasks = new List<RepTask>();
                RepTask currentTask = this.Prev;

                while (currentTask != null)
                {
                    tasks.Add(currentTask);
                    currentTask = currentTask.Prev;
                }

                return tasks;
            }
        }

        public new RepTask DeepCopy()
        {
            RepTask copy = new RepTask();

            copy.AbsoluteStartTime = this.AbsoluteStartTime;
            copy.Duration = this.Duration;
            copy.Date = this.Date;
            copy.Description = this.Description;
            copy.Note = this.Note;
            copy.Location = this.Location;
            copy.Done = this.Done;
            copy.Frequency = this.Frequency;

            foreach (var subTask in this.SubTasks)
            {
                copy.AddSubTask(subTask.DeepCopy());
            }

            return copy;
        }

        public Task ReturnCopyTask()
        {
            Task newTask = new Task()
            {
                Description = this.Description,
                Note = this.Note,
                Location = this.Location,

                StartHour = this.StartHour,
                StartMinute = this.StartMinute,
                Duration = this.Duration,
                Date = this.Date,

                SubTasks = this.SubTasks
            };

            return newTask;
        }
    }
}

using Schodennik;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class UniversalHelper
{
    public static Dictionary<int, string> indexToDayName = new Dictionary<int, string>
    {
        {0, "понеділок"},
        {1, "вівторок"},
        {2, "середа"},
        {3, "четвер"},
        {4, "п'ятниця"},
        {5, "субота"},
        {6, "неділя"}
    };

    public static string FormatTwoDigitNumber(int number)
    {
        if (number < 0 || number > 99)
        {
            throw new ArgumentException("число має бути від 0 до 99");
        }

        return (number < 10) ? $"0{number}" : number.ToString();
    }

    public static string MinuteToHHMMFormat(int minute)
    {
        int hours = minute / 60;
        int minutes = minute % 60;

        string timeFormat = string.Format("{0:D2}:{1:D2}", hours, minutes);

        return timeFormat;
    }

    public static int ConvertTimeStringToAbsoluteTime(string timeString)
    {
        char[] separators = { ':' };

        string[] timeParts = timeString.Split(separators);

        if (!int.TryParse(timeParts[0], out int hours))
        {
            throw new ArgumentException("невірний формат часу: не вдалося отримати число із години");
        }

        if (timeParts.Length != 2 || !int.TryParse(timeParts[1], out int minutes))
        {
            throw new ArgumentException("невірний формат часу: не вдалося отримати число із хвилини");
        }

        if (hours < 0 || hours > 23 || minutes < 0 || minutes > 59)
        {
            throw new ArgumentException("невірний формат часу: неможливі значення");
        }

        int absoluteTime = hours * 60 + minutes;

        return absoluteTime;
    }

    public static BindingList<T> ListToBindList<T>(List<T> list)
    {
        BindingList<T> bindList = new BindingList<T>();
        if (DataHolder.IsInitialized(list) && list.Count > 0)
        {
            foreach (T item in list)
            {
                bindList.Add(item);
            }
            return bindList;
        }
        else return new BindingList<T>();

    }

    public static int FindNearestAvailableTime(Task newTask, int minPossibleStartTime, int duration, DateTime date, List<Task> exceptionList = null)
    {
        if (exceptionList == null) exceptionList = new List<Task>();

        List<Task> tasksOnDate = DataHolder.AllExceptThis(date, exceptionList);

        tasksOnDate = tasksOnDate.OrderBy(t => t.AbsoluteStartTime).ToList();

        int currentTime = minPossibleStartTime;

        foreach (var task in tasksOnDate)
        {
            if (currentTime + duration <= task.AbsoluteStartTime)
            {
                
                if (IsTimeSlotAvailable(newTask, currentTime, tasksOnDate))
                {
                    return currentTime;
                }
            }

            if (currentTime < task.EndTime)
            {
                currentTime = task.EndTime;
            }
        }
        
        //перевыірка часу після останньої задачі
        if (currentTime + duration <= 1440)
        {
            return currentTime;
        }

        return -1;
    }

    private static bool IsTimeSlotAvailable(Task newTask, int startTime, List<Task> tasksOnDate)
    {
        int newTaskEndTime = startTime + newTask.Duration;

        foreach (var task in tasksOnDate)
        {
            if (!(newTaskEndTime <= task.AbsoluteStartTime || startTime >= task.EndTime))
            {
                return false;
            }
        }

        return true;
    }


    public static DateTime GetMondayDate(DateTime date)
    {
        DayOfWeek startOfWeek = CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;
        DayOfWeek currentDayOfWeek = date.DayOfWeek;

        int daysToSubtract = (7 + (currentDayOfWeek - startOfWeek)) % 7;
        DateTime monday = date.Date.AddDays(-daysToSubtract);

        return monday;
    }

    public static DateTime GetFirstDayOfMonth(DateTime date)
    {
        return new DateTime(date.Year, date.Month, 1);
    }

    public static void ClearControls(this Panel panel)
    {
        foreach (Control control in panel.Controls)
        {
            control.Dispose();
        }
        panel.Controls.Clear();
    }


    //для теми
    public enum ColorElement
    {
        ContorlsBackground,
        Background,
        Header,
        Container,
        Button,
        Text
    }

    public static Dictionary<string, Dictionary<ColorElement, Color>> Themes { get; } = new Dictionary<string, Dictionary<ColorElement, Color>>()
    {
        ["Default"] = new Dictionary<ColorElement, Color>
        {
            { ColorElement.Background, Color.Moccasin },
            { ColorElement.ContorlsBackground, Color.PapayaWhip },
            { ColorElement.Button, Color.White },
            { ColorElement.Container, Color.SeaShell},
            { ColorElement.Header, Color.FromArgb(255, 240, 110, 130)},
            { ColorElement.Text, Color.Black}
        },
        ["CandyMoon"] = new Dictionary<ColorElement, Color>
        {
            { ColorElement.Background, Color.FromArgb(255, 31, 37, 68) },
            { ColorElement.ContorlsBackground, Color.FromArgb(255, 71, 79, 122) },
            { ColorElement.Button, Color.White },
            { ColorElement.Container, Color.FromArgb(255, 255, 208, 236)},
            { ColorElement.Header, Color.FromArgb(255, 129, 104, 157)},
            { ColorElement.Text, Color.White}
        },
        ["PolishBeaver"] = new Dictionary<ColorElement, Color>
        {
            { ColorElement.Background, Color.FromArgb(255, 245, 222, 179) },
            { ColorElement.ContorlsBackground, Color.FromArgb(255, 255, 228, 181) },
            { ColorElement.Button, Color.FromArgb(255, 210, 180, 140) },
            { ColorElement.Container, Color.FromArgb(255, 255, 248, 220)},
            { ColorElement.Header, Color.FromArgb(255, 205, 133, 63)},
            { ColorElement.Text, Color.Black}
        },
        ["ForestArcher"] = new Dictionary<ColorElement, Color>
        {
            { ColorElement.Background, Color.FromArgb(173, 188, 159)},
            { ColorElement.ContorlsBackground, Color.FromArgb(67, 104, 80) },
            { ColorElement.Button, Color.White },
            { ColorElement.Container, Color.FromArgb(251, 250, 218) },
            { ColorElement.Header,  Color.FromArgb(18, 55, 42)},
            { ColorElement.Text, Color.White }
        }
    };
}


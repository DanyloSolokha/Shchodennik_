using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UniversalHelper;

namespace Schodennik
{
    public partial class mainWindow
    {
        public void ShowAllPlaned()
        {
            ShowDayTasks(SelectedDate);
            ShowWeekTasks(SelectedDate);
            ShowMonthTask(SelectedDate);
        }

        public void ShowDayTasks(DateTime d)
        {
            DayPanel.ClearControls();

            List<Task> allInDate = DataHolder.AllTaskInDate(d);
            foreach (Task task in allInDate)
            {
                new TaskItemControl(DayPanel, task);
            }

        }

        public void ShowWeekTasks(DateTime date)
        {
            DateTime monday = UniversalHelper.GetMondayDate(date);

            foreach (Panel p in WeekPanel.Controls)
            {
                p.ClearControls();
            }
            if (DataHolder.TaskDictionary == default) return;

            for (int i = 0; i < 7; i++)
            {
                DateTime d = monday.AddDays(i);

                string panelName = $"{i}DayPanel";
                Panel dayPanel = (Panel)WeekPanel.Controls.Find(panelName, false).FirstOrDefault();

                List<Task> ThisDayTasks = DataHolder.AllTaskInDate(d);
                foreach (Task task in ThisDayTasks)
                {
                    new TaskItemControl(dayPanel, task);
                }
            }
        }

        public int GetNumberDayOfWeek(DateTime date)
        {
            CultureInfo cultureInfo = CultureInfo.CurrentCulture;
            DayOfWeek dayOfWeek = cultureInfo.Calendar.GetDayOfWeek(date);

            DateTimeFormatInfo dateTimeInfo = cultureInfo.DateTimeFormat;

            return ((int)dayOfWeek - (int)dateTimeInfo.FirstDayOfWeek + 7) % 7;
        }

        public void ShowMonthTask(DateTime date)
        {
            HideCalendarCells();

            DateTime firstDay = UniversalHelper.GetFirstDayOfMonth(date);
            DateTime nextFirstDay = UniversalHelper.GetFirstDayOfMonth(date.AddMonths(1));

            int weekNumber = 0;

            for (DateTime current = firstDay; current < nextFirstDay; current = current.AddDays(1))
            {
                int dayOfWeek = GetNumberDayOfWeek(current);

                if (dayOfWeek == 0 && current != firstDay) weekNumber++;

                int column = dayOfWeek;
                int row = weekNumber;

                CalendarCell cell = GetCalendarCell(row, column);

                if (cell != null)
                {
                    cell.Show();

                    List<Task> all = DataHolder.AllTaskInDate(current);

                    cell.Date = current;
                    cell.TaskPlaned = all;
                    cell.DayNumber = current.Day;

                }
            }
        }

        public CalendarCell GetCalendarCell(int row, int col)
        {
            if (col >= 0 && col < 7 && row >= 0 && row < 6)
            {
                return arrayOfCells[col, row];
            }
            return null;
        }

        public void ShowBasicTasks()
        {
            BindingList<BasicTask> b = UniversalHelper.ListToBindList(DataHolder.GetAllIncompleteBasicTasks());
            BasicTaskListBox.DataSource = b;
        }

        public void ShowStats()
        {
            WeekStat.Text = DataHolder.GetWeekStat(SelectedDate).ToString();
            MonthStat.Text = DataHolder.GetMonthStat(SelectedDate).ToString();
            YearStat.Text = DataHolder.GetYearStat(SelectedDate).ToString();
        }

        public static bool MakeTask(string description, string note, string location, int startHour, int startMinute, int duration, DateTime date)
        {
            return TaskHelper.CreateAndAddTask(description, note, location, startHour, startMinute, duration, date) != null;
        }

        public static bool MakeRepChainTask(string description, string note, string location, int startHour, int startMinute, int duration, DateTime date, DateTime endDate, int frequency)
        {
            return TaskHelper.CreateAndAddRepTaskChain(description, note, location, startHour, startMinute, duration, date, endDate, frequency) != null;
        }

        private void MakeBasicTask(string description, string note, string location)
        {
            BasicTask task = new BasicTask();

            if (description.Length > 0) task.Description = description;
            if (note.Length > 0) task.Note = note;
            if (location.Length > 0) task.Location = location;

            task.AddToHolder();
        }

        public static void ChangeTextColors(Control control, Color textColor)
        {
            foreach (Control c in control.Controls)
            {
                if (c is CalendarCell || c is TaskItemControl)
                {
                    continue;
                }

                if (c is Label || c is LinkLabel || c is CheckBox)
                {
                    c.ForeColor = textColor;
                    if (c is LinkLabel linkLabel)
                    {
                        linkLabel.LinkColor = textColor;
                        linkLabel.VisitedLinkColor = textColor;
                        linkLabel.DisabledLinkColor = textColor;
                    }
                }
                else if (c.Controls.Count > 0)
                {
                    ChangeTextColors(c, textColor);
                }
            }
        }


        public void ShowTimeScale(Panel taskPanel, Panel timeScalePanel)
        {
            for (int i = 0; i <= 24; i += 4)
            {
                System.Windows.Forms.Label l = new System.Windows.Forms.Label();
                l.Font = new Font("Segoe UI", 14, FontStyle.Regular);
                double proportion = (double)i / 24;
                int height = (int)(proportion * taskPanel.Height + (-timeScalePanel.Location.Y + taskPanel.Location.Y));
                l.Location = new Point(0, height - (l.Height / 2));
                string formattedText = $"--------{i:00}:00";
                l.Text = formattedText;
                timeScalePanel.Controls.Add(l);
                l.AutoSize = true;
            }
        }

        public void AddWeekSubPanels()
        {
            int panelWidth = (int)((double)WeekPanel.Width / 7);
            for (int i = 0; i < 7; i++)
            {

                Panel dayPanel = new Panel();

                dayPanel.Size = new Size(panelWidth, WeekPanel.Height);
                dayPanel.Location = new Point(i * panelWidth, 0);
                dayPanel.BorderStyle = BorderStyle.FixedSingle;

                dayPanel.Name = $"{(i)}DayPanel";


                WeekPanel.Controls.Add(dayPanel);
            }
        }


        public void AddCalendarCells()
        {
            for (int row = 0; row < MonthTableLayoutPanel.RowCount; row++)
            {
                for (int col = 0; col < MonthTableLayoutPanel.ColumnCount; col++)
                {
                    CalendarCell cell = new CalendarCell();
                    MonthTableLayoutPanel.Controls.Add(cell, col, row);
                    arrayOfCells[col, row] = cell;
                }
            }
        }

        public void HideCalendarCells()
        {
            for (int row = 0; row < MonthTableLayoutPanel.RowCount; row++)
            {
                for (int col = 0; col < MonthTableLayoutPanel.ColumnCount; col++)
                {

                    CalendarCell cell = GetCalendarCell(row, col);

                    cell.Hide();

                }
            }
        }

        private void ColorThemeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            colorTheme = ColorThemeComboBox.Text;

            Color backGround = UniversalHelper.Themes[colorTheme][ColorElement.Background];
            Color controlsBg = UniversalHelper.Themes[colorTheme][ColorElement.ContorlsBackground];
            Color container = UniversalHelper.Themes[colorTheme][ColorElement.Container];
            Color header = UniversalHelper.Themes[colorTheme][ColorElement.Header];
            Color text = UniversalHelper.Themes[colorTheme][ColorElement.Text];

            this.BackColor = backGround;

            panelCreateTask.BackColor = header;
            panelBasikTask.BackColor = header;
            panelDayName.BackColor = header;
            panelDaysInWeekName.BackColor = header;
            panelDaysInMonthName.BackColor = header;
            panelSettings.BackColor = header;
            panelStat.BackColor = header;

            DayPanel.BackColor = container;
            WeekPanel.BackColor = container;
            MonthTableLayoutPanel.BackColor = container;
            BasicTaskListBox.BackColor = container;

            statContainer.BackColor = controlsBg;
            settingsContainer.BackColor = controlsBg;
            PropertyPanel.BackColor = controlsBg;

            DaySubPanel.BackColor = backGround;
            weekSubPanel.BackColor = backGround;
            MonthSubPanel.BackColor = backGround;
            tabPage1.BackColor = backGround;
            tabPage2.BackColor = backGround;
            tabPage3.BackColor = backGround;

            ChangeTextColors(this, text);

        }
    }
}

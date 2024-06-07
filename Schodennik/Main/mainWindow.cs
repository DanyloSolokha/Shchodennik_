using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Transactions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static UniversalHelper;

namespace Schodennik
{

    public partial class mainWindow : Form
    {
        public string colorTheme;

        private static readonly string PATH_TO_TASKS = Path.Combine(Program.BaseDirectory, "Data", "tasks.txt");
        private static readonly string PATH_TO_BASICTASKS = Path.Combine(Program.BaseDirectory, "Data", "basicTasks.txt");
        private static readonly string PATH_TO_REP_TASKS = Path.Combine(Program.BaseDirectory, "Data", "repTasks.txt");

        private List<Task> todayTasks = new List<Task>();
        private List<Task> tomorrowTasks = new List<Task>();

        private static CalendarCell[,] arrayOfCells = new CalendarCell[7, 6];

        private System.Timers.Timer timer;

        private DateTime _selectedDate = DateTime.Today;
        private DateTime _currentDate = DateTime.Today;

        public DateTime SelectedDate
        {
            get { return _selectedDate; }
            set
            {
                if (_selectedDate != value)
                {
                    _selectedDate = value;
                    OnSelectedDateChanged(new DateChangedEventArgs(value));
                }
            }
        }

        protected virtual void OnSelectedDateChanged(DateChangedEventArgs e)
        {
            SelectedDateChanged?.Invoke(this, e);
        }

        public event EventHandler<DateChangedEventArgs> SelectedDateChanged;

        public class DateChangedEventArgs : EventArgs
        {
            public DateTime NewDate { get; }

            public DateChangedEventArgs(DateTime newDate)
            {
                NewDate = newDate;
            }
        }

        private void mainWindow_SelectedDateChanged(object sender, DateChangedEventArgs e)
        {
            DateTime nd = e.NewDate;

            MainDatePicker.Value = nd;
            EndDateTimePicker.Value = nd.AddMonths(1);

            ShowDayTasks(nd);
            DayNameLabel.Text = UniversalHelper.indexToDayName[GetNumberDayOfWeek(nd)] + " " + SelectedDate.ToString("dd/MM/yy");

            WeekDateTimePicker.Value = nd;
            ShowWeekTasks(nd);
            DateTime currentDate = UniversalHelper.GetMondayDate(e.NewDate);
            for (int i = 0; i < 7; i++)
            {
                string labelName = $"Day{i}Label";
                System.Windows.Forms.Label foundLabel = Controls.Find(labelName, true).FirstOrDefault() as System.Windows.Forms.Label;
                foundLabel.Text = $"{UniversalHelper.indexToDayName[i]} {currentDate.ToString("dd/MM")}";
                currentDate = currentDate.AddDays(1);
            }

            MonthDateTimePicker.Value = e.NewDate;
            ShowMonthTask(e.NewDate);

            dateTimePickerDate.Value = e.NewDate;

            ShowStats();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DateTime now = DateTime.Now;

            if (now.Date != _currentDate)
            {
                _currentDate = now.Date;
                DataHolder.UpdateTaskCollections();
            }

            foreach (var task in DataHolder.TodayTasks.Concat(DataHolder.TomorrowTasks))
            {
                DateTime taskStartTime = task.Date.AddMinutes(task.AbsoluteStartTime);
                double minutesUntilTask = taskStartTime.Subtract(now).TotalMinutes;

                if (Math.Abs(minutesUntilTask - 5) < 0.1)
                {
                    ShowNotification(task);
                }
            }
        }

        private void ShowNotification(Task task)
        {
            NotifyIcon notifyIcon = new NotifyIcon
            {
                Icon = SystemIcons.Information,
                Visible = true,
                BalloonTipTitle = "Нагадування",
                BalloonTipText = $"Задача: {task.Description} почненться через 5 хвилин."
            };
            notifyIcon.ShowBalloonTip(5000);
        }

        public mainWindow()
        {
            //налаштування зовнішнього вигляду

            InitializeComponent();

            ShowTimeScale(DayPanel, TimeScalePanel);
            ShowTimeScale(WeekPanel, TimeScalePanelForWeek);
            AddWeekSubPanels();

            AddCalendarCells();

            StartMinuteСomboBox.SelectedIndex = 0;
            StartHourСomboBox.SelectedIndex = 0;
            DurationComboBox.SelectedIndex = 5;
            FrequencyComboBox.SelectedIndex = 0;
            ColorThemeComboBox.SelectedIndex = 0;

            MainDatePicker.Value = DateTime.Today;
            MonthDateTimePicker.CustomFormat = "MM/yyyy";

            //завантаження даних

            List<BasicTask> loadedBasicTaskList = JsonHelper.LoadFromFile<List<BasicTask>>(PATH_TO_BASICTASKS);
            DataHolder.BasicTaskList = UniversalHelper.ListToBindList(loadedBasicTaskList);

            DataHolder.TaskDictionary = JsonHelper.LoadFromFile<Dictionary<DateTime, List<Task>>>(PATH_TO_TASKS);
            DataHolder.RepTaskDictionary = JsonHelper.LoadFromFile<Dictionary<DateTime, List<RepTask>>>(PATH_TO_REP_TASKS);

            if (!DataHolder.IsInitialized(DataHolder.TaskDictionary))
            {
                DataHolder.TaskDictionary = new Dictionary<DateTime, List<Task>>();
            }

            if (!DataHolder.IsInitialized(DataHolder.BasicTaskList))
            {
                DataHolder.BasicTaskList = new BindingList<BasicTask>();
            }

            if (!DataHolder.IsInitialized(DataHolder.RepTaskDictionary))
            {
                DataHolder.RepTaskDictionary = new Dictionary<DateTime, List<RepTask>>();
            }

            timer = new System.Timers.Timer(10000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            SelectedDateChanged += mainWindow_SelectedDateChanged;
            OnSelectedDateChanged(new DateChangedEventArgs(SelectedDate));

            BasicTaskListBox.DisplayMember = "Description";

            ShowBasicTasks();
            ShowAllPlaned();
            ShowStats();

            DataHolder.EnsureDateExistsInDictionary(DateTime.Today);
            todayTasks = DataHolder.AllTaskInDate(DateTime.Today);
        }


        //створити задачу
        private void CreateTaskButton_Click(object sender, EventArgs e)
        {

            string description = DescriptionTextBox.Text.Trim();
            string note = NoteTextBox.Text.Trim();
            string location = LocationTextBox.Text.Trim();

            if (PlanedCheckBox.Checked)
            {

                int duration = UniversalHelper.ConvertTimeStringToAbsoluteTime(DurationComboBox.Text);
                int startHour = Convert.ToInt32(StartHourСomboBox.Text);
                int startMinute = Convert.ToInt32(StartMinuteСomboBox.Text);
                DateTime date = dateTimePickerDate.Value.Date;

                if (RepeatedCheckBox.Checked)
                {
                    //reptask

                    DateTime endDate = EndDateTimePicker.Value.Date;
                    int frequency = Convert.ToInt32(FrequencyComboBox.SelectedItem);

                    if (frequency <= 0)
                    {
                        MessageBox.Show("частота має бути більша за 0", "помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MakeRepChainTask(description, note, location, startHour, startMinute, duration, date, endDate, frequency);
                    }
                }
                else
                {
                    //task

                    MakeTask(description, note, location, startHour, startMinute, duration, date);
                }

                ShowAllPlaned();

            }
            else
            {
                //bt

                MakeBasicTask(description, note, location);
                ShowBasicTasks();
                ShowStats();
            }
        }


        //зміна обраної дати
        private void DatePickers_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker d = (DateTimePicker)sender;
            DateTime t = d.Value.Date;

            SelectedDate = t;
        }

        private void WeekDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker d = (DateTimePicker)sender;
            DateTime t = d.Value.Date;

            SelectedDate = t;
        }

        private void MonthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker d = (DateTimePicker)sender;
            DateTime t = d.Value.Date;

            SelectedDate = t;
        }

        //видалити всі задачі
        private void clear_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Ви впевненні що хочете видалити все задачі?", "Видалення всіх задач", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                DataHolder.TaskDictionary = new Dictionary<DateTime, List<Task>>();
                DataHolder.BasicTaskList = new BindingList<BasicTask>();
                DataHolder.RepTaskDictionary = new Dictionary<DateTime, List<RepTask>>();

                ShowAllPlaned();
                ShowBasicTasks();
                ShowStats();

                JsonHelper.ClearFile(PATH_TO_TASKS);
                JsonHelper.ClearFile(PATH_TO_BASICTASKS);
                JsonHelper.ClearFile(PATH_TO_REP_TASKS);
            }

        }

        //чекбокси для вибору запланованих справ
        private void PlanedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TimeSettingPanel.Enabled = PlanedCheckBox.Checked;
        }

        private void RepeatedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RepPanel.Enabled = RepeatedCheckBox.Checked;
        }

        //відкрити спонтанну справу
        private void BasicTaskListBox_DoubleClick(object sender, EventArgs e)
        {
            if (this.BasicTaskListBox.SelectedItem != null)
            {
                EditForm editForm = new EditForm((BasicTask)BasicTaskListBox.SelectedItem);
                editForm.ShowDialog();
            }

        }

        //показати зроблені спонтанні справи
        private void OpenDoneTaskLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoneTaskForm f = new DoneTaskForm();
            f.ShowDialog();
        }


        //збереження даних під час закриття
        private void mainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            JsonHelper.SaveToFile(DataHolder.TaskDictionary, PATH_TO_TASKS);

            List<BasicTask> basicTaskList = DataHolder.BasicTaskList.ToList();
            JsonHelper.SaveToFile(basicTaskList, PATH_TO_BASICTASKS);

            JsonHelper.SaveToFile(DataHolder.RepTaskDictionary, PATH_TO_REP_TASKS);
        }

        //кнопки вперед/назад
        private void DayBackwardButton_Click(object sender, EventArgs e)
        {
            SelectedDate = SelectedDate.AddDays(-1);
        }

        private void DayForwardButton_Click(object sender, EventArgs e)
        {
            SelectedDate = SelectedDate.AddDays(1);
        }

        private void WeekBackWardButton_Click(object sender, EventArgs e)
        {
            SelectedDate = SelectedDate.AddDays(-7);
        }

        private void WeekForwardButton_Click(object sender, EventArgs e)
        {
            SelectedDate = SelectedDate.AddDays(7);
        }

        private void MonthBackwardButton_Click(object sender, EventArgs e)
        {
            SelectedDate = SelectedDate.AddMonths(-1);
        }

        private void MonthForwardButton_Click(object sender, EventArgs e)
        {
            SelectedDate = SelectedDate.AddMonths(1);
        }

        private void Day0Label_Click(object sender, EventArgs e)
        {
            SelectedDate = GetMondayDate(SelectedDate);
            TabControl.SelectedIndex = 0;
        }

        private void Day1Label_Click(object sender, EventArgs e)
        {
            SelectedDate = GetMondayDate(SelectedDate).AddDays(1);
            TabControl.SelectedIndex = 0;
        }

        private void Day2Label_Click(object sender, EventArgs e)
        {
            SelectedDate = GetMondayDate(SelectedDate).AddDays(2);
            TabControl.SelectedIndex = 0;
        }

        private void Day3Label_Click(object sender, EventArgs e)
        {
            SelectedDate = GetMondayDate(SelectedDate).AddDays(3);
            TabControl.SelectedIndex = 0;
        }

        private void Day4Label_Click(object sender, EventArgs e)
        {
            SelectedDate = GetMondayDate(SelectedDate).AddDays(4);
            TabControl.SelectedIndex = 0;
        }

        private void Day5Label_Click(object sender, EventArgs e)
        {
            SelectedDate = GetMondayDate(SelectedDate).AddDays(5);
            TabControl.SelectedIndex = 0;
        }

        private void Day6Label_Click(object sender, EventArgs e)
        {
            SelectedDate = GetMondayDate(SelectedDate).AddDays(6);
            TabControl.SelectedIndex = 0;
        }
    }
}

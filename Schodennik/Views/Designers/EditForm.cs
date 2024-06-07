using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static UniversalHelper;

namespace Schodennik
{
    public partial class EditForm : Form
    {
        BasicTask task;

        Color controlsBg = UniversalHelper.Themes[Program.MainWindow.colorTheme][ColorElement.ContorlsBackground];
        Color text = UniversalHelper.Themes[Program.MainWindow.colorTheme][ColorElement.Text];

        public EditForm(BasicTask task)
        {
            InitializeComponent();

            this.BackColor = controlsBg;
            mainWindow.ChangeTextColors(this, text);

            this.task = task;

            DescriptionTextBox.Text = task.Description;
            NoteTextBox.Text = task.Note;
            LocationTextBox.Text = task.Location;

            DoneCheckBox.Checked = task.Done;

            dateTimePickerDate.Value = DateTime.Today;
            EndDateTimePicker.Value = DateTime.Today.AddMonths(1);

            FrequencyComboBox.SelectedIndex = 0;

            if (task is Task taskDerived)
            {
                PlanedCheckBox.Checked = true;
                dateTimePickerDate.Value = taskDerived.Date;

                int startHour = taskDerived.StartHour;
                int startMinute = taskDerived.StartMinute;

                StartHourСomboBox.Text = UniversalHelper.FormatTwoDigitNumber(startHour);
                StartMinuteСomboBox.Text = UniversalHelper.FormatTwoDigitNumber(startMinute);

                DurationComboBox.Text = UniversalHelper.MinuteToHHMMFormat(taskDerived.Duration);

                dateTimePickerDate.Value = taskDerived.Date;

                if (taskDerived is RepTask taskDoubleDerived)
                {
                    //reptask
                    EndDateTimePicker.Value = taskDoubleDerived.LastDate;

                    RepeatedCheckBox.Checked = true;
                    FrequencyComboBox.Text = taskDoubleDerived.Frequency.ToString();

                    ShowFirstLinkLabel.Enabled = true;
                    ShowLastLinkLabel.Enabled = true;

                    FrequencyComboBox.Text = taskDoubleDerived.Frequency.ToString();
                }
            }
            else
            {
                //bt
                dateTimePickerDate.Value = Program.MainWindow.SelectedDate;

                StartMinuteСomboBox.SelectedIndex = 0;
                StartHourСomboBox.SelectedIndex = 0;
                DurationComboBox.SelectedIndex = 5;
            }

        }
        public EditForm()
        {
            InitializeComponent();
        }
        public void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void EditTaskButton_Click(object sender, EventArgs e)
        {
            BasicTask task = this.task;

            string description = DescriptionTextBox.Text;
            string note = NoteTextBox.Text;
            string location = LocationTextBox.Text;

            bool done = DoneCheckBox.Checked;

            int startHour = Convert.ToInt32(StartHourСomboBox.Text);
            int startMinute = Convert.ToInt32(StartMinuteСomboBox.Text);
            int duration = UniversalHelper.ConvertTimeStringToAbsoluteTime(DurationComboBox.Text);
            DateTime date = dateTimePickerDate.Value.Date;

            DateTime endDate = EndDateTimePicker.Value.Date;
            int frequency = Convert.ToInt32(FrequencyComboBox.Text);

            if (task is Task taskDerived)
            {
                if (taskDerived is RepTask taskDoubleDerived)
                {
                    //rep => ...
                    if (PlanedCheckBox.Checked)
                    {
                        if (RepeatedCheckBox.Checked)
                        {
                            //rep => rep
                            TaskHelper.UpdateRep(taskDoubleDerived, description, note, location, done, startHour, startMinute, duration, date, endDate, frequency);
                        }
                        else
                        {
                            //rep => task

                            TaskHelper.RepToTask(taskDoubleDerived, description, note, location, done, startHour, startMinute, duration, date);
                        }
                    }
                    else
                    {
                        //rep => bt

                        TaskHelper.RepToBasicTask(taskDoubleDerived, description, note, location, done);
                    }
                }
                else
                {
                    //Task => ...

                    if (PlanedCheckBox.Checked)
                    {
                        if (RepeatedCheckBox.Checked)
                        {
                            //task => alt

                            TaskHelper.TaskToRep(taskDerived, description, note, location, done, startHour, startMinute, duration, date, endDate, frequency);

                        }
                        else
                        {
                            //task => task

                            TaskHelper.UpdateTask(taskDerived, description, note, location, done, startHour, startMinute, duration, date);
                        }
                    }
                    else
                    {
                        //task => bt

                        TaskHelper.TaskToBasicTask(taskDerived, description, note, location, done);
                    }

                }

            }
            else
            {
                //bt => ...
                if (PlanedCheckBox.Checked)
                {
                    if (RepeatedCheckBox.Checked)
                    {
                        //bt => alt

                        TaskHelper.BasicTaskToRep(task, description, note, location, done, startHour, startMinute, duration, date, endDate, frequency);
                    }
                    else
                    {
                        //bt => task

                        TaskHelper.BasicTaskToTask(task, description, note, location, done, startHour, startMinute, duration, date);
                    }
                }
                else
                {
                    //BT => BT

                    TaskHelper.UpdateBasicTask(task, description, note, location, done);
                }
            }

            this.Close();
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            BasicTask task = this.task;

            if (task is Task taskDerived)
            {
                if (task is RepTask taskDoubleDerived)
                {
                    if (taskDoubleDerived.Next != null)
                    {
                        using (SelectModeForm form = new SelectModeForm("тільки цю", "всі наступні"))
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                if (form.SelectedMode == SelectModeForm.RescheduleMode.firstMode)
                                {
                                    // тільки ця
                                    TaskHelper.CheckOnePrev(taskDoubleDerived);
                                    TaskHelper.CheckOneForward(taskDoubleDerived);

                                    taskDoubleDerived.RemoveFromHolder();
                                    taskDoubleDerived.DisapearFromChain();


                                }
                                else if (form.SelectedMode == SelectModeForm.RescheduleMode.secondMode)
                                {
                                    // всі наступні
                                    TaskHelper.CheckOnePrev(taskDoubleDerived);

                                    List<RepTask> list = taskDoubleDerived.ThisAndAllSubsequentTasks;
                                    foreach (var t in list)
                                    {
                                        t.RemoveFromHolder();
                                        t.DisapearFromChain();
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        taskDoubleDerived.RemoveFromHolder();
                        taskDoubleDerived.DisapearFromChain();
                    }
                }
                else
                {
                    taskDerived.RemoveFromHolder();
                }
            }
            else
            {
                task.RemoveFromHolder();
            }

            this.Close();
        }

        private void PlanedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TimeSettingPanel.Enabled = PlanedCheckBox.Checked;
            RepeatedCheckBox.Enabled = PlanedCheckBox.Checked;
        }

        private void SubTasksLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SubTaskForm f = new SubTaskForm(this.task);
            f.ShowDialog();
        }

        private void RepeatedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (RepeatedCheckBox.Checked)
                {
                    RepPanel.Enabled = true;
                }
                else
                {
                    RepPanel.Enabled = false;
                }
            }
        }


        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainWindow.ShowAllPlaned();

            Program.MainWindow.ShowBasicTasks();

            Program.MainWindow.ShowStats();

        }

        private void ShowFirstLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.task is RepTask repTask)
            {
                RepTask firstInChain = repTask.FirstInChain;

                Program.MainWindow.SelectedDate = firstInChain.Date;
                Program.MainWindow.TabControl.SelectedIndex = 0;

                this.Close();
            }
        }

        private void ShowLastLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.task is RepTask repTask)
            {
                RepTask lastInChain = repTask.LastInChain;

                Program.MainWindow.SelectedDate = lastInChain.Date;
                Program.MainWindow.TabControl.SelectedIndex = 0;

                this.Close();
            }
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}

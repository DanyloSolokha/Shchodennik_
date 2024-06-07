using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Schodennik
{
    public partial class CalendarCell : UserControl
    {

        DateTime _date;

        public CalendarCell()
        {
            InitializeComponent();
        }

        public int DayNumber
        {
            set
            {
                dayNumberLabel.Text = value.ToString();
            }
        }

        public List<Task> TaskPlaned
        {
            set
            {
                int duration = 0;
                foreach (var task in value)
                {
                    duration += task.Duration;
                }

                durationNumberLabel.Text = "розплановано: " + UniversalHelper.MinuteToHHMMFormat(duration);

                int countAllTasks = value.Count;
                int countDoneTasks = value.Count(t => t.Done);

                this.BackColor = Color.Transparent;

                if (value == null || countAllTasks == 0)
                {
                    numberOfTaskLabel.LinkColor = Color.DimGray;
                    durationNumberLabel.ForeColor = Color.DimGray;
                }
                else
                {
                    numberOfTaskLabel.LinkColor = Color.Black;
                    durationNumberLabel.ForeColor = Color.Black;
                    if (countAllTasks == countDoneTasks)
                    {
                        this.BackColor = Color.MediumSpringGreen;
                    }
                }



                numberOfTaskLabel.Text = countDoneTasks.ToString() + "/" + countAllTasks.ToString();
            }
        }

        public DateTime Date
        {
            set
            {
                _date = value.Date;
            }
        }

        private void numberOfTaskLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.MainWindow.TabControl.SelectedIndex = 0;
            Program.MainWindow.SelectedDate = this._date;
        }
    }
}

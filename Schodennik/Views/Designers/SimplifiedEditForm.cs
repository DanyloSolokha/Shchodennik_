using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UniversalHelper;

namespace Schodennik
{
    public partial class SimplifiedEditForm : Form
    {
        Color controlsBg = UniversalHelper.Themes[Program.MainWindow.colorTheme][ColorElement.ContorlsBackground];
        Color text = UniversalHelper.Themes[Program.MainWindow.colorTheme][ColorElement.Text];

        BasicTask task;
        BindingList<BasicTask> bl;
        public SimplifiedEditForm(BasicTask task, BindingList<BasicTask> bl)
        {
            InitializeComponent();

            this.BackColor = controlsBg;
            mainWindow.ChangeTextColors(this, text);

            this.task = task;
            this.bl = bl;

            DescriptionTextBox.Text = task.Description;
            NoteTextBox.Text = task.Note;
            LocationTextBox.Text = task.Location;

            DoneCheckBox.Checked = task.Done;
            this.bl = bl;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SubTaskForm f = new SubTaskForm(this.task);
            f.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
                this.bl.Remove(this.task);
                this.Close();

                
        }

        private void EditTaskButton_Click(object sender, EventArgs e)
        {

            string description = this.DescriptionTextBox.Text;
            string note = this.NoteTextBox.Text;
            string location = this.LocationTextBox.Text;

            bool done = DoneCheckBox.Checked;

            TaskHelper.UpdateBasicTask(task, description, note, location, done);

            this.Close();
        }
    }
}

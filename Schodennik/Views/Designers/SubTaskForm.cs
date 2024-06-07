using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UniversalHelper;

namespace Schodennik
{
    public partial class SubTaskForm : Form
    {
        BasicTask task;
        public BindingList<BasicTask> bindList = new BindingList<BasicTask>();

        Color controlsBg = UniversalHelper.Themes[Program.MainWindow.colorTheme][ColorElement.ContorlsBackground];
        Color container = UniversalHelper.Themes[Program.MainWindow.colorTheme][ColorElement.Container];
        Color text = UniversalHelper.Themes[Program.MainWindow.colorTheme][ColorElement.Text];

        public SubTaskForm(BasicTask task)
        {
            InitializeComponent();

            this.BackColor = controlsBg;
            mainWindow.ChangeTextColors(this, text);
            SubTaskListBox.BackColor = container;

            this.task = task;

            if (task.SubTasks.Count > 0) bindList = UniversalHelper.ListToBindList(task.SubTasks);

            SubTaskListBox.DisplayMember = "Description";
            SubTaskListBox.DataSource = bindList;
        }

        private void ListBox_DoubleClick(object sender, EventArgs e)
        {
            if (this.SubTaskListBox.SelectedItem != null)
            {
                SimplifiedEditForm f = new SimplifiedEditForm((BasicTask)this.SubTaskListBox.SelectedItem, bindList);
                f.ShowDialog();
                bindList.ResetBindings();
            }
        }

        private void CreateSubTaskButton_Click(object sender, EventArgs e)
        {
            BasicTask task = new BasicTask();

            string description = DescriptionTextBox.Text.Trim();
            string note = NoteTextBox.Text.Trim();
            string location = LocationTextBox.Text.Trim();

            if (description.Length > 0) task.Description = description;
            if (note.Length > 0) task.Note = note;
            if (location.Length > 0) task.Location = location;

            this.bindList.Add(task);
        }

        private void EditTaskButton_Click(object sender, EventArgs e)
        {
            if (this.task is RepTask taskDerived)
            {
                using (SelectModeForm form = new SelectModeForm("зберігти зміни тільки для цієї задачі", "зберігти зміни для всіх наступних задач"))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.SelectedMode == SelectModeForm.RescheduleMode.firstMode)
                        {
                            taskDerived.SubTasks = this.bindList.ToList();
                            this.Close();
                        }
                        else if (form.SelectedMode == SelectModeForm.RescheduleMode.secondMode)
                        {
                            List<RepTask> allForward = taskDerived.ThisAndAllSubsequentTasks;
                            foreach (var t in allForward) t.SubTasks = this.bindList.ToList();
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                this.task.SubTasks = this.bindList.ToList();
                this.Close();
            }
        }
    }
}

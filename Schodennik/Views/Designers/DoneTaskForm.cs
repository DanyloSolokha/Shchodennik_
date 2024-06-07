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
    public partial class DoneTaskForm : Form
    {

        BindingList<BasicTask> b = new BindingList<BasicTask>();

        Color backGround = UniversalHelper.Themes[Program.MainWindow.colorTheme][ColorElement.Background];
        Color controlsBg = UniversalHelper.Themes[Program.MainWindow.colorTheme][ColorElement.ContorlsBackground];
        Color container = UniversalHelper.Themes[Program.MainWindow.colorTheme][ColorElement.Container];
        Color header = UniversalHelper.Themes[Program.MainWindow.colorTheme][ColorElement.Header];
        Color button = UniversalHelper.Themes[Program.MainWindow.colorTheme][ColorElement.Button];
        Color text = UniversalHelper.Themes[Program.MainWindow.colorTheme][ColorElement.Text];

        public DoneTaskForm()
        {

            InitializeComponent();

            this.BackColor = controlsBg;
            mainWindow.ChangeTextColors(this, text);

            DoneBasicTaskListBox.BackColor = container;

            List<BasicTask> l = DataHolder.GetAllCompletedBasicTasks();
            b = UniversalHelper.ListToBindList(l);

            DoneBasicTaskListBox.DisplayMember = "Description";
            DoneBasicTaskListBox.DataSource = b;
        }

        private void SubTaskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DoneBasicTaskListBox_DoubleClick(object sender, EventArgs e)
        {
            if (this.DoneBasicTaskListBox.SelectedItem != null)
            {
                SimplifiedEditForm f = new SimplifiedEditForm((BasicTask)this.DoneBasicTaskListBox.SelectedItem, b);
                f.ShowDialog();
                b.ResetBindings();
                Program.MainWindow.ShowBasicTasks();

                List<BasicTask> l = DataHolder.GetAllCompletedBasicTasks();
                b = UniversalHelper.ListToBindList(l);

                DoneBasicTaskListBox.DataSource = b; 

            }
        }
    }
}

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
    public partial class SelectModeForm : Form
    {

        public enum RescheduleMode
        {
            firstMode,
            secondMode,
            thirdMode,
            fourthMode
        }
        public RescheduleMode SelectedMode { get; private set; }

        Color controlsBg = UniversalHelper.Themes[Program.MainWindow.colorTheme][ColorElement.ContorlsBackground];
        Color text = UniversalHelper.Themes[Program.MainWindow.colorTheme][ColorElement.Text];

        public SelectModeForm(string first, string second, string third, string fourth)
        {
            InitializeComponent();

            this.BackColor = controlsBg;
            mainWindow.ChangeTextColors(this, text);

            FirstModeButton.Text = first;
            SecondModeButton.Text = second;
            ThirdModeButton.Text = third;

        }

        public SelectModeForm(string first, string second)
        {
            InitializeComponent();

            this.BackColor = controlsBg;
            mainWindow.ChangeTextColors(this, text);

            FirstModeButton.Text = first;
            SecondModeButton.Text = second;

            ThirdModeButton.Enabled = false;
            ThirdModeButton.Hide();
            ThirdModeButton.Text = "...";

            FourthModeButton.Enabled = false;
            FourthModeButton.Hide();
            FourthModeButton.Text = "...";
        }

        private void OnlyThisButton_Click(object sender, EventArgs e)
        {
            SelectedMode = RescheduleMode.firstMode;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AllForwardButton_Click(object sender, EventArgs e)
        {
            SelectedMode = RescheduleMode.secondMode;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectedMode = RescheduleMode.thirdMode;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AllForwardContentOnlyButton_Click(object sender, EventArgs e)
        {
            SelectedMode = RescheduleMode.fourthMode;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SelectModeForm_Load(object sender, EventArgs e)
        {

        }
    }
}

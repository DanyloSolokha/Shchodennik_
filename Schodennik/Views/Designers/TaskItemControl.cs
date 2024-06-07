using Schodennik;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TaskItemControl : UserControl
{
    public TaskItemControl prev = null;
    public Task task;
    public Panel parentPanel;
    private Panel panel1;
    public CheckBox checkBox;
    private Panel panel2;
    public Label TimeLabel;
    public Label NoteLabel;
    public Label DescriptionLabel;

    public Color taskColor = Color.DeepSkyBlue;
    public Color doneTaskColor = Color.MediumSpringGreen;
    public Color repTaskColor = Color.MediumOrchid;

    public TaskItemControl(Panel mainPanel, Task task)
    {
        InitializeComponent();

        this.BackColor = taskColor;

        this.parentPanel = mainPanel;

        this.task = task;

        int mainPanelWidth = mainPanel.Width;

        int taskPanelWidth = mainPanelWidth;
        this.Width = taskPanelWidth;

        int panelHeight = (task.Duration * mainPanel.Height) / 1440;
        this.Height = panelHeight;

        int location = (task.AbsoluteStartTime * mainPanel.Height) / 1440;
        this.Location = new Point(0, location);

        if (task is RepTask taskDerived)
        {
            this.BackColor = repTaskColor;
        }

        Font f = new Font("Arial", 10f, FontStyle.Regular);

        DescriptionLabel.Text = task.Description;
        DescriptionLabel.Font = f;




        if (panelHeight < 25)
        {
            panel1.Hide();
            this.MouseEnter += Panel_MouseEnter;
        }

        if (this.Width < 300)
        {
            this.NoteLabel.Hide();
            this.TimeLabel.Hide();
        }
        else
        {
            this.DescriptionLabel.Text = "опис: " + this.DescriptionLabel.Text;

            NoteLabel.Text = "замітка: " + task.Note;
            NoteLabel.Font = f;

            TimeLabel.Text = UniversalHelper.MinuteToHHMMFormat(task.AbsoluteStartTime) + " - " + UniversalHelper.MinuteToHHMMFormat(task.EndTime);
            TimeLabel.Font = f;

            this.DescriptionLabel.Width = (int)((double)panel2.Width * 0.3);
            this.NoteLabel.Width = (int)((double)panel2.Width * 0.5);
            this.TimeLabel.Width = (int)((double)panel2.Width * 0.2);
        }

        if (this.task.Done == true)
        {
            checkBox.Checked = true;
            this.BackColor = doneTaskColor;
        }


        this.DoubleClick += Panel_Click;
        DescriptionLabel.DoubleClick += Panel_Click;
        NoteLabel.DoubleClick += Panel_Click;
        TimeLabel.DoubleClick += Panel_Click;

        checkBox.CheckedChanged += CheckBox_CheckedChanged;

        parentPanel.Controls.Add(this);

    }

    public TaskItemControl(Panel mainPanel, Task task, int height)
    {
        InitializeComponent();

        this.BackColor = taskColor;

        this.parentPanel = mainPanel;

        this.task = task;

        int mainPanelWidth = mainPanel.Width;

        int taskPanelWidth = mainPanelWidth;
        this.Width = taskPanelWidth;


        this.Height = height;

        int halfHeight = (int)((double)height / 2);

        int location = (task.AbsoluteStartTime * mainPanel.Height) / 1440;

        if (location - halfHeight < 0)
        {
            this.Location = new Point(0, 0);
        }
        else if (location + halfHeight > parentPanel.Height)
        {
            this.Location = new Point(0, parentPanel.Height - height);
        }
        else
        {
            this.Location = new Point(0, location - halfHeight);
        }


        if (task is RepTask)
        {
            this.BackColor = repTaskColor;
        }

        Font f = new Font("Arial", 10f, FontStyle.Regular);

        DescriptionLabel.Text = task.Description;
        DescriptionLabel.Font = f;

        if (this.Width < 300)
        {
            this.NoteLabel.Hide();
            this.TimeLabel.Hide();

            this.DescriptionLabel.Width = panel2.Width;
        }
        else
        {
            this.DescriptionLabel.Width = (int)((double)panel2.Width * 0.3);
            this.NoteLabel.Width = (int)((double)panel2.Width * 0.5);
            this.TimeLabel.Width = (int)((double)panel2.Width * 0.2);


            this.DescriptionLabel.Text = "опис: " + this.DescriptionLabel.Text;

            NoteLabel.Text = "замітка: " + task.Note;
            NoteLabel.Font = f;

            TimeLabel.Text = UniversalHelper.MinuteToHHMMFormat(task.AbsoluteStartTime) + " - " + UniversalHelper.MinuteToHHMMFormat(task.EndTime);
            TimeLabel.Font = f;
        }

        if (this.task.Done == true)
        {
            checkBox.Checked = true;
            this.BackColor = doneTaskColor;
        }

        this.DoubleClick += Panel_Click;
        DescriptionLabel.DoubleClick += Panel_Click;
        NoteLabel.DoubleClick += Panel_Click;
        TimeLabel.DoubleClick += Panel_Click;

        if (this.task.Done == true)
        {
            checkBox.Checked = true;
            this.BackColor = Color.Aquamarine;
        }

        checkBox.CheckedChanged += CheckBox_CheckedChanged;

        parentPanel.Controls.Add(this);
    }

    private void Panel_MouseEnter(object sender, EventArgs e)
    {
        TaskItemControl newTaskItemControl = new TaskItemControl(this.parentPanel, this.task, 60);
        newTaskItemControl.MouseLeave += Panel_MouseLeave;
        newTaskItemControl.DescriptionLabel.MouseLeave += Label_MouseLeave;
        newTaskItemControl.BringToFront();
        newTaskItemControl.prev = this;
        this.Hide();
    }

    private void Panel_MouseLeave(object sender, EventArgs e)
    {
        TaskItemControl newTaskItemControl = (TaskItemControl)sender;
        newTaskItemControl.prev.Show();
        newTaskItemControl.Dispose();
    }

    private void Label_MouseLeave(object sender, EventArgs e)
    {
        OnMouseLeave(e);
    }

    private void Panel_Click(object sender, EventArgs e)
    {
        EditForm editForm = new EditForm(this.task);
        editForm.ShowDialog();
    }

    private void CheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox.Checked)
        {
            this.task.Done = true;
        }
        else
        {
            this.task.Done = false;
        }

        Program.MainWindow.ShowAllPlaned();
        Program.MainWindow.ShowStats();
    }

    private void BookmarkPanel_Paint(object sender, PaintEventArgs e)
    {

    }

    private void InitializeComponent()
    {
        panel1 = new Panel();
        panel2 = new Panel();
        TimeLabel = new Label();
        NoteLabel = new Label();
        DescriptionLabel = new Label();
        checkBox = new CheckBox();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.DeepSkyBlue;
        panel1.Controls.Add(panel2);
        panel1.Controls.Add(checkBox);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(3, 3);
        panel1.Margin = new Padding(0);
        panel1.Name = "panel1";
        panel1.Size = new Size(382, 86);
        panel1.TabIndex = 3;
        panel1.DoubleClick += Panel_Click;
        // 
        // panel2
        // 
        panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        panel2.BackColor = Color.WhiteSmoke;
        panel2.Controls.Add(TimeLabel);
        panel2.Controls.Add(NoteLabel);
        panel2.Controls.Add(DescriptionLabel);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(0, 0);
        panel2.Margin = new Padding(0);
        panel2.Name = "panel2";
        panel2.Size = new Size(367, 86);
        panel2.TabIndex = 15;
        // 
        // TimeLabel
        // 
        TimeLabel.AutoEllipsis = true;
        TimeLabel.BackColor = Color.WhiteSmoke;
        TimeLabel.Dock = DockStyle.Left;
        TimeLabel.Location = new Point(271, 0);
        TimeLabel.Margin = new Padding(3);
        TimeLabel.Name = "TimeLabel";
        TimeLabel.Padding = new Padding(2);
        TimeLabel.Size = new Size(80, 86);
        TimeLabel.TabIndex = 9;
        TimeLabel.Text = "час";
        TimeLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // NoteLabel
        // 
        NoteLabel.AutoEllipsis = true;
        NoteLabel.BackColor = Color.WhiteSmoke;
        NoteLabel.Dock = DockStyle.Left;
        NoteLabel.Location = new Point(131, 0);
        NoteLabel.Name = "NoteLabel";
        NoteLabel.Padding = new Padding(2);
        NoteLabel.Size = new Size(140, 86);
        NoteLabel.TabIndex = 8;
        NoteLabel.Text = "замітка";
        // 
        // DescriptionLabel
        // 
        DescriptionLabel.AutoEllipsis = true;
        DescriptionLabel.BackColor = Color.WhiteSmoke;
        DescriptionLabel.Dock = DockStyle.Left;
        DescriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 204);
        DescriptionLabel.Location = new Point(0, 0);
        DescriptionLabel.Margin = new Padding(3);
        DescriptionLabel.Name = "DescriptionLabel";
        DescriptionLabel.Padding = new Padding(2);
        DescriptionLabel.Size = new Size(131, 86);
        DescriptionLabel.TabIndex = 7;
        DescriptionLabel.Text = "опис";
        // 
        // checkBox
        // 
        checkBox.AutoSize = true;
        checkBox.BackColor = Color.LightGray;
        checkBox.Dock = DockStyle.Right;
        checkBox.Location = new Point(367, 0);
        checkBox.Name = "checkBox";
        checkBox.Size = new Size(15, 86);
        checkBox.TabIndex = 12;
        checkBox.TextAlign = ContentAlignment.TopRight;
        checkBox.UseVisualStyleBackColor = false;
        // 
        // TaskItemControl
        // 
        BackColor = Color.MediumOrchid;
        BorderStyle = BorderStyle.FixedSingle;
        Controls.Add(panel1);
        Margin = new Padding(0);
        Name = "TaskItemControl";
        Padding = new Padding(3);
        Size = new Size(388, 92);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        ResumeLayout(false);
    }

    private void label_Click(object sender, EventArgs e)
    {

    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void DescriptionLabel_Click(object sender, EventArgs e)
    {

    }

    private void NoteLabel_Click(object sender, EventArgs e)
    {

    }

    private void LocationLabel_Click(object sender, EventArgs e)
    {

    }
}
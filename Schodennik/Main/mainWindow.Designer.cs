namespace Schodennik
{
    partial class mainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            TabControl = new TabControl();
            tabPage1 = new TabPage();
            DaySubPanel = new Panel();
            DayForwardButton = new Button();
            DayBackwardButton = new Button();
            DayPanel = new Panel();
            panelDayName = new Panel();
            DayNameLabel = new Label();
            TimeScalePanel = new Panel();
            MainDatePicker = new DateTimePicker();
            tabPage2 = new TabPage();
            weekSubPanel = new Panel();
            WeekForwardButton = new Button();
            WeekBackWardButton = new Button();
            panelDaysInWeekName = new Panel();
            Day4Label = new Label();
            Day6Label = new Label();
            Day1Label = new Label();
            Day0Label = new Label();
            Day5Label = new Label();
            Day2Label = new Label();
            Day3Label = new Label();
            TimeScalePanelForWeek = new Panel();
            WeekDateTimePicker = new DateTimePicker();
            WeekPanel = new Panel();
            tabPage3 = new TabPage();
            MonthSubPanel = new Panel();
            MonthForwardButton = new Button();
            MonthBackwardButton = new Button();
            panelDaysInMonthName = new Panel();
            Day0LabelMonth = new Label();
            Day6LabelMonth = new Label();
            Day1LabelMonth = new Label();
            label10 = new Label();
            Day5LabelMonth = new Label();
            Day2LabelMonth = new Label();
            Day3LabelMonth = new Label();
            Day4LabelMonth = new Label();
            MonthTableLayoutPanel = new TableLayoutPanel();
            MonthDateTimePicker = new DateTimePicker();
            panelSettings = new Panel();
            settingsLabel = new Label();
            panelBasikTask = new Panel();
            BasicTaskLabel = new Label();
            panelStat = new Panel();
            statLabel = new Label();
            statContainer = new Panel();
            YearStat = new Label();
            MonthStat = new Label();
            WeekStat = new Label();
            YearStatLabel = new Label();
            MonthStatLabel = new Label();
            WeekStatLabel = new Label();
            settingsContainer = new Panel();
            ThemeLabel = new Label();
            clear = new Button();
            ColorThemeComboBox = new ComboBox();
            OpenDoneTaskLinkLabel = new LinkLabel();
            BasicTaskListBox = new ListBox();
            panelCreateTask = new Panel();
            createTaskLabel = new Label();
            PropertyPanel = new Panel();
            TimeSettingPanel = new Panel();
            RepPanel = new Panel();
            EndDateTimePicker = new DateTimePicker();
            someText6 = new Label();
            FrequencyComboBox = new ComboBox();
            someText5 = new Label();
            someText4 = new Label();
            RepeatedCheckBox = new CheckBox();
            dateTimePickerDate = new DateTimePicker();
            StartMinuteСomboBox = new ComboBox();
            Colon = new Label();
            DurationComboBox = new ComboBox();
            someText2 = new Label();
            someText1 = new Label();
            StartHourСomboBox = new ComboBox();
            someText3 = new Label();
            PlanedCheckBox = new CheckBox();
            Location = new Label();
            LocationTextBox = new TextBox();
            NoteTextBox = new TextBox();
            Note = new Label();
            CreateTaskButton = new Button();
            Description = new Label();
            DescriptionTextBox = new TextBox();
            label3 = new Label();
            TabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            DaySubPanel.SuspendLayout();
            panelDayName.SuspendLayout();
            tabPage2.SuspendLayout();
            weekSubPanel.SuspendLayout();
            panelDaysInWeekName.SuspendLayout();
            tabPage3.SuspendLayout();
            MonthSubPanel.SuspendLayout();
            panelDaysInMonthName.SuspendLayout();
            panelSettings.SuspendLayout();
            panelBasikTask.SuspendLayout();
            panelStat.SuspendLayout();
            statContainer.SuspendLayout();
            settingsContainer.SuspendLayout();
            panelCreateTask.SuspendLayout();
            PropertyPanel.SuspendLayout();
            TimeSettingPanel.SuspendLayout();
            RepPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabPage1);
            TabControl.Controls.Add(tabPage2);
            TabControl.Controls.Add(tabPage3);
            TabControl.Location = new Point(529, 3);
            TabControl.Multiline = true;
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1056, 978);
            TabControl.SizeMode = TabSizeMode.FillToRight;
            TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(71, 79, 122);
            tabPage1.Controls.Add(DaySubPanel);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1048, 950);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "день";
            // 
            // DaySubPanel
            // 
            DaySubPanel.BackColor = Color.FromArgb(71, 79, 122);
            DaySubPanel.BorderStyle = BorderStyle.FixedSingle;
            DaySubPanel.Controls.Add(DayForwardButton);
            DaySubPanel.Controls.Add(DayBackwardButton);
            DaySubPanel.Controls.Add(DayPanel);
            DaySubPanel.Controls.Add(panelDayName);
            DaySubPanel.Controls.Add(TimeScalePanel);
            DaySubPanel.Controls.Add(MainDatePicker);
            DaySubPanel.Location = new Point(9, 9);
            DaySubPanel.Name = "DaySubPanel";
            DaySubPanel.Size = new Size(1036, 941);
            DaySubPanel.TabIndex = 5;
            // 
            // DayForwardButton
            // 
            DayForwardButton.Location = new Point(414, 3);
            DayForwardButton.Name = "DayForwardButton";
            DayForwardButton.Size = new Size(160, 23);
            DayForwardButton.TabIndex = 33;
            DayForwardButton.Text = "вперед";
            DayForwardButton.UseVisualStyleBackColor = true;
            DayForwardButton.Click += DayForwardButton_Click;
            // 
            // DayBackwardButton
            // 
            DayBackwardButton.Location = new Point(248, 3);
            DayBackwardButton.Name = "DayBackwardButton";
            DayBackwardButton.Size = new Size(160, 23);
            DayBackwardButton.TabIndex = 32;
            DayBackwardButton.Text = "назад";
            DayBackwardButton.UseVisualStyleBackColor = true;
            DayBackwardButton.Click += DayBackwardButton_Click;
            // 
            // DayPanel
            // 
            DayPanel.BackColor = Color.FromArgb(255, 208, 236);
            DayPanel.BorderStyle = BorderStyle.FixedSingle;
            DayPanel.Location = new Point(-1, 54);
            DayPanel.Name = "DayPanel";
            DayPanel.Size = new Size(896, 863);
            DayPanel.TabIndex = 1;
            // 
            // panelDayName
            // 
            panelDayName.BackColor = Color.FromArgb(129, 104, 157);
            panelDayName.BorderStyle = BorderStyle.FixedSingle;
            panelDayName.Controls.Add(DayNameLabel);
            panelDayName.Location = new Point(-1, 27);
            panelDayName.Name = "panelDayName";
            panelDayName.Size = new Size(896, 28);
            panelDayName.TabIndex = 22;
            // 
            // DayNameLabel
            // 
            DayNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DayNameLabel.AutoSize = true;
            DayNameLabel.ForeColor = Color.White;
            DayNameLabel.Location = new Point(379, 6);
            DayNameLabel.Name = "DayNameLabel";
            DayNameLabel.Size = new Size(72, 15);
            DayNameLabel.TabIndex = 12;
            DayNameLabel.Text = "Поненділок";
            // 
            // TimeScalePanel
            // 
            TimeScalePanel.Location = new Point(899, -1);
            TimeScalePanel.Name = "TimeScalePanel";
            TimeScalePanel.Size = new Size(132, 941);
            TimeScalePanel.TabIndex = 4;
            // 
            // MainDatePicker
            // 
            MainDatePicker.CalendarMonthBackground = Color.White;
            MainDatePicker.Location = new Point(3, 3);
            MainDatePicker.Name = "MainDatePicker";
            MainDatePicker.Size = new Size(239, 23);
            MainDatePicker.TabIndex = 3;
            MainDatePicker.ValueChanged += DatePickers_ValueChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Moccasin;
            tabPage2.Controls.Add(weekSubPanel);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1048, 950);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "тиждень";
            // 
            // weekSubPanel
            // 
            weekSubPanel.BackColor = Color.Moccasin;
            weekSubPanel.BorderStyle = BorderStyle.FixedSingle;
            weekSubPanel.Controls.Add(WeekForwardButton);
            weekSubPanel.Controls.Add(WeekBackWardButton);
            weekSubPanel.Controls.Add(panelDaysInWeekName);
            weekSubPanel.Controls.Add(TimeScalePanelForWeek);
            weekSubPanel.Controls.Add(WeekDateTimePicker);
            weekSubPanel.Controls.Add(WeekPanel);
            weekSubPanel.Location = new Point(9, 9);
            weekSubPanel.Name = "weekSubPanel";
            weekSubPanel.Size = new Size(1036, 941);
            weekSubPanel.TabIndex = 6;
            // 
            // WeekForwardButton
            // 
            WeekForwardButton.Location = new Point(414, 3);
            WeekForwardButton.Name = "WeekForwardButton";
            WeekForwardButton.Size = new Size(160, 23);
            WeekForwardButton.TabIndex = 32;
            WeekForwardButton.Text = "вперед";
            WeekForwardButton.UseVisualStyleBackColor = true;
            WeekForwardButton.Click += WeekForwardButton_Click;
            // 
            // WeekBackWardButton
            // 
            WeekBackWardButton.Location = new Point(248, 3);
            WeekBackWardButton.Name = "WeekBackWardButton";
            WeekBackWardButton.Size = new Size(160, 23);
            WeekBackWardButton.TabIndex = 31;
            WeekBackWardButton.Text = "назад";
            WeekBackWardButton.UseVisualStyleBackColor = true;
            WeekBackWardButton.Click += WeekBackWardButton_Click;
            // 
            // panelDaysInWeekName
            // 
            panelDaysInWeekName.BackColor = Color.FromArgb(240, 110, 130);
            panelDaysInWeekName.BorderStyle = BorderStyle.FixedSingle;
            panelDaysInWeekName.Controls.Add(Day4Label);
            panelDaysInWeekName.Controls.Add(Day6Label);
            panelDaysInWeekName.Controls.Add(Day1Label);
            panelDaysInWeekName.Controls.Add(Day0Label);
            panelDaysInWeekName.Controls.Add(Day5Label);
            panelDaysInWeekName.Controls.Add(Day2Label);
            panelDaysInWeekName.Controls.Add(Day3Label);
            panelDaysInWeekName.Location = new Point(-1, 27);
            panelDaysInWeekName.Name = "panelDaysInWeekName";
            panelDaysInWeekName.Size = new Size(896, 28);
            panelDaysInWeekName.TabIndex = 21;
            // 
            // Day4Label
            // 
            Day4Label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Day4Label.AutoSize = true;
            Day4Label.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            Day4Label.Location = new Point(536, 6);
            Day4Label.Name = "Day4Label";
            Day4Label.Size = new Size(57, 15);
            Day4Label.TabIndex = 16;
            Day4Label.Text = "П'ятниця";
            Day4Label.TextAlign = ContentAlignment.MiddleLeft;
            Day4Label.Click += Day4Label_Click;
            // 
            // Day6Label
            // 
            Day6Label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Day6Label.AutoSize = true;
            Day6Label.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            Day6Label.Location = new Point(788, 6);
            Day6Label.Name = "Day6Label";
            Day6Label.Size = new Size(44, 15);
            Day6Label.TabIndex = 18;
            Day6Label.Text = "Неділя";
            Day6Label.TextAlign = ContentAlignment.MiddleLeft;
            Day6Label.Click += Day6Label_Click;
            // 
            // Day1Label
            // 
            Day1Label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Day1Label.AutoSize = true;
            Day1Label.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            Day1Label.Location = new Point(152, 6);
            Day1Label.Name = "Day1Label";
            Day1Label.Size = new Size(55, 15);
            Day1Label.TabIndex = 13;
            Day1Label.Text = "Вівторок";
            Day1Label.TextAlign = ContentAlignment.MiddleLeft;
            Day1Label.Click += Day1Label_Click;
            // 
            // Day0Label
            // 
            Day0Label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Day0Label.AutoSize = true;
            Day0Label.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            Day0Label.Location = new Point(18, 6);
            Day0Label.Name = "Day0Label";
            Day0Label.Size = new Size(72, 15);
            Day0Label.TabIndex = 12;
            Day0Label.Text = "Поненділок";
            Day0Label.TextAlign = ContentAlignment.MiddleLeft;
            Day0Label.Click += Day0Label_Click;
            // 
            // Day5Label
            // 
            Day5Label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Day5Label.AutoSize = true;
            Day5Label.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            Day5Label.Location = new Point(667, 6);
            Day5Label.Name = "Day5Label";
            Day5Label.Size = new Size(46, 15);
            Day5Label.TabIndex = 17;
            Day5Label.Text = "Субота";
            Day5Label.TextAlign = ContentAlignment.MiddleLeft;
            Day5Label.Click += Day5Label_Click;
            // 
            // Day2Label
            // 
            Day2Label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Day2Label.AutoSize = true;
            Day2Label.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            Day2Label.Location = new Point(280, 6);
            Day2Label.Name = "Day2Label";
            Day2Label.Size = new Size(46, 15);
            Day2Label.TabIndex = 14;
            Day2Label.Text = "Середа";
            Day2Label.TextAlign = ContentAlignment.MiddleLeft;
            Day2Label.Click += Day2Label_Click;
            // 
            // Day3Label
            // 
            Day3Label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Day3Label.AutoSize = true;
            Day3Label.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            Day3Label.Location = new Point(411, 6);
            Day3Label.Name = "Day3Label";
            Day3Label.Size = new Size(45, 15);
            Day3Label.TabIndex = 15;
            Day3Label.Text = "Четвер";
            Day3Label.TextAlign = ContentAlignment.MiddleLeft;
            Day3Label.Click += Day3Label_Click;
            // 
            // TimeScalePanelForWeek
            // 
            TimeScalePanelForWeek.Location = new Point(899, -1);
            TimeScalePanelForWeek.Name = "TimeScalePanelForWeek";
            TimeScalePanelForWeek.Size = new Size(132, 941);
            TimeScalePanelForWeek.TabIndex = 30;
            // 
            // WeekDateTimePicker
            // 
            WeekDateTimePicker.Location = new Point(3, 3);
            WeekDateTimePicker.Name = "WeekDateTimePicker";
            WeekDateTimePicker.Size = new Size(239, 23);
            WeekDateTimePicker.TabIndex = 3;
            WeekDateTimePicker.ValueChanged += WeekDateTimePicker_ValueChanged;
            // 
            // WeekPanel
            // 
            WeekPanel.BackColor = Color.SeaShell;
            WeekPanel.BorderStyle = BorderStyle.FixedSingle;
            WeekPanel.Location = new Point(-1, 54);
            WeekPanel.Name = "WeekPanel";
            WeekPanel.Size = new Size(896, 863);
            WeekPanel.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Moccasin;
            tabPage3.Controls.Add(MonthSubPanel);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1048, 950);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "місяць";
            // 
            // MonthSubPanel
            // 
            MonthSubPanel.BackColor = Color.Moccasin;
            MonthSubPanel.BorderStyle = BorderStyle.FixedSingle;
            MonthSubPanel.Controls.Add(MonthForwardButton);
            MonthSubPanel.Controls.Add(MonthBackwardButton);
            MonthSubPanel.Controls.Add(panelDaysInMonthName);
            MonthSubPanel.Controls.Add(MonthTableLayoutPanel);
            MonthSubPanel.Controls.Add(MonthDateTimePicker);
            MonthSubPanel.Location = new Point(9, 9);
            MonthSubPanel.Name = "MonthSubPanel";
            MonthSubPanel.Size = new Size(1036, 941);
            MonthSubPanel.TabIndex = 19;
            // 
            // MonthForwardButton
            // 
            MonthForwardButton.Location = new Point(414, 3);
            MonthForwardButton.Name = "MonthForwardButton";
            MonthForwardButton.Size = new Size(160, 23);
            MonthForwardButton.TabIndex = 33;
            MonthForwardButton.Text = "вперед";
            MonthForwardButton.UseVisualStyleBackColor = true;
            MonthForwardButton.Click += MonthForwardButton_Click;
            // 
            // MonthBackwardButton
            // 
            MonthBackwardButton.Location = new Point(248, 3);
            MonthBackwardButton.Name = "MonthBackwardButton";
            MonthBackwardButton.Size = new Size(160, 23);
            MonthBackwardButton.TabIndex = 32;
            MonthBackwardButton.Text = "назад";
            MonthBackwardButton.UseVisualStyleBackColor = true;
            MonthBackwardButton.Click += MonthBackwardButton_Click;
            // 
            // panelDaysInMonthName
            // 
            panelDaysInMonthName.BackColor = Color.FromArgb(240, 110, 130);
            panelDaysInMonthName.BorderStyle = BorderStyle.FixedSingle;
            panelDaysInMonthName.Controls.Add(Day0LabelMonth);
            panelDaysInMonthName.Controls.Add(Day6LabelMonth);
            panelDaysInMonthName.Controls.Add(Day1LabelMonth);
            panelDaysInMonthName.Controls.Add(label10);
            panelDaysInMonthName.Controls.Add(Day5LabelMonth);
            panelDaysInMonthName.Controls.Add(Day2LabelMonth);
            panelDaysInMonthName.Controls.Add(Day3LabelMonth);
            panelDaysInMonthName.Controls.Add(Day4LabelMonth);
            panelDaysInMonthName.Location = new Point(-1, 27);
            panelDaysInMonthName.Name = "panelDaysInMonthName";
            panelDaysInMonthName.Size = new Size(1005, 28);
            panelDaysInMonthName.TabIndex = 19;
            // 
            // Day0LabelMonth
            // 
            Day0LabelMonth.AutoSize = true;
            Day0LabelMonth.Location = new Point(45, 6);
            Day0LabelMonth.Name = "Day0LabelMonth";
            Day0LabelMonth.Size = new Size(65, 15);
            Day0LabelMonth.TabIndex = 20;
            Day0LabelMonth.Text = "Понеділок";
            // 
            // Day6LabelMonth
            // 
            Day6LabelMonth.AutoSize = true;
            Day6LabelMonth.Location = new Point(902, 6);
            Day6LabelMonth.Name = "Day6LabelMonth";
            Day6LabelMonth.Size = new Size(44, 15);
            Day6LabelMonth.TabIndex = 18;
            Day6LabelMonth.Text = "Неділя";
            // 
            // Day1LabelMonth
            // 
            Day1LabelMonth.AutoSize = true;
            Day1LabelMonth.Location = new Point(190, 6);
            Day1LabelMonth.Name = "Day1LabelMonth";
            Day1LabelMonth.Size = new Size(55, 15);
            Day1LabelMonth.TabIndex = 13;
            Day1LabelMonth.Text = "Вівторок";
            // 
            // label10
            // 
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(100, 23);
            label10.TabIndex = 19;
            // 
            // Day5LabelMonth
            // 
            Day5LabelMonth.AutoSize = true;
            Day5LabelMonth.Location = new Point(766, 6);
            Day5LabelMonth.Name = "Day5LabelMonth";
            Day5LabelMonth.Size = new Size(46, 15);
            Day5LabelMonth.TabIndex = 17;
            Day5LabelMonth.Text = "Субота";
            // 
            // Day2LabelMonth
            // 
            Day2LabelMonth.AutoSize = true;
            Day2LabelMonth.Location = new Point(335, 6);
            Day2LabelMonth.Name = "Day2LabelMonth";
            Day2LabelMonth.Size = new Size(46, 15);
            Day2LabelMonth.TabIndex = 14;
            Day2LabelMonth.Text = "Середа";
            // 
            // Day3LabelMonth
            // 
            Day3LabelMonth.AutoSize = true;
            Day3LabelMonth.Location = new Point(476, 6);
            Day3LabelMonth.Name = "Day3LabelMonth";
            Day3LabelMonth.Size = new Size(45, 15);
            Day3LabelMonth.TabIndex = 15;
            Day3LabelMonth.Text = "Четвер";
            // 
            // Day4LabelMonth
            // 
            Day4LabelMonth.AutoSize = true;
            Day4LabelMonth.Location = new Point(613, 6);
            Day4LabelMonth.Name = "Day4LabelMonth";
            Day4LabelMonth.Size = new Size(57, 15);
            Day4LabelMonth.TabIndex = 16;
            Day4LabelMonth.Text = "П'ятниця";
            // 
            // MonthTableLayoutPanel
            // 
            MonthTableLayoutPanel.BackColor = Color.SeaShell;
            MonthTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            MonthTableLayoutPanel.ColumnCount = 7;
            MonthTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857113F));
            MonthTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857161F));
            MonthTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857161F));
            MonthTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857161F));
            MonthTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857161F));
            MonthTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857161F));
            MonthTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857161F));
            MonthTableLayoutPanel.Location = new Point(-1, 54);
            MonthTableLayoutPanel.Name = "MonthTableLayoutPanel";
            MonthTableLayoutPanel.RowCount = 6;
            MonthTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6673584F));
            MonthTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6673622F));
            MonthTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6673622F));
            MonthTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6673622F));
            MonthTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6673584F));
            MonthTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6631966F));
            MonthTableLayoutPanel.Size = new Size(1005, 847);
            MonthTableLayoutPanel.TabIndex = 11;
            // 
            // MonthDateTimePicker
            // 
            MonthDateTimePicker.Format = DateTimePickerFormat.Custom;
            MonthDateTimePicker.Location = new Point(3, 3);
            MonthDateTimePicker.Name = "MonthDateTimePicker";
            MonthDateTimePicker.Size = new Size(239, 23);
            MonthDateTimePicker.TabIndex = 3;
            MonthDateTimePicker.ValueChanged += MonthDateTimePicker_ValueChanged;
            // 
            // panelSettings
            // 
            panelSettings.BackColor = Color.FromArgb(129, 104, 157);
            panelSettings.BorderStyle = BorderStyle.FixedSingle;
            panelSettings.Controls.Add(settingsLabel);
            panelSettings.Location = new Point(1601, 294);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(252, 28);
            panelSettings.TabIndex = 27;
            // 
            // settingsLabel
            // 
            settingsLabel.AutoSize = true;
            settingsLabel.BackColor = Color.Transparent;
            settingsLabel.ForeColor = Color.White;
            settingsLabel.Location = new Point(100, 8);
            settingsLabel.Name = "settingsLabel";
            settingsLabel.Size = new Size(34, 15);
            settingsLabel.TabIndex = 0;
            settingsLabel.Text = "Інше";
            // 
            // panelBasikTask
            // 
            panelBasikTask.BackColor = Color.FromArgb(129, 104, 157);
            panelBasikTask.BorderStyle = BorderStyle.FixedSingle;
            panelBasikTask.Controls.Add(BasicTaskLabel);
            panelBasikTask.Location = new Point(271, 64);
            panelBasikTask.Name = "panelBasikTask";
            panelBasikTask.Size = new Size(239, 28);
            panelBasikTask.TabIndex = 26;
            // 
            // BasicTaskLabel
            // 
            BasicTaskLabel.AutoSize = true;
            BasicTaskLabel.BackColor = Color.Transparent;
            BasicTaskLabel.ForeColor = Color.White;
            BasicTaskLabel.Location = new Point(66, 6);
            BasicTaskLabel.Name = "BasicTaskLabel";
            BasicTaskLabel.Size = new Size(100, 15);
            BasicTaskLabel.TabIndex = 0;
            BasicTaskLabel.Text = "Спонтанні задачі";
            // 
            // panelStat
            // 
            panelStat.BackColor = Color.FromArgb(129, 104, 157);
            panelStat.BorderStyle = BorderStyle.FixedSingle;
            panelStat.Controls.Add(statLabel);
            panelStat.Location = new Point(1601, 64);
            panelStat.Name = "panelStat";
            panelStat.Size = new Size(252, 28);
            panelStat.TabIndex = 26;
            // 
            // statLabel
            // 
            statLabel.AutoSize = true;
            statLabel.BackColor = Color.Transparent;
            statLabel.ForeColor = Color.White;
            statLabel.Location = new Point(92, 8);
            statLabel.Name = "statLabel";
            statLabel.Size = new Size(68, 15);
            statLabel.TabIndex = 0;
            statLabel.Text = "Статистика";
            // 
            // statContainer
            // 
            statContainer.BackColor = Color.FromArgb(71, 79, 122);
            statContainer.BorderStyle = BorderStyle.FixedSingle;
            statContainer.Controls.Add(YearStat);
            statContainer.Controls.Add(MonthStat);
            statContainer.Controls.Add(WeekStat);
            statContainer.Controls.Add(YearStatLabel);
            statContainer.Controls.Add(MonthStatLabel);
            statContainer.Controls.Add(WeekStatLabel);
            statContainer.Location = new Point(1601, 91);
            statContainer.Name = "statContainer";
            statContainer.Size = new Size(252, 147);
            statContainer.TabIndex = 25;
            // 
            // YearStat
            // 
            YearStat.AutoSize = true;
            YearStat.Font = new Font("Segoe UI", 12F);
            YearStat.ForeColor = Color.White;
            YearStat.Location = new Point(176, 101);
            YearStat.Name = "YearStat";
            YearStat.Size = new Size(19, 21);
            YearStat.TabIndex = 6;
            YearStat.Text = "0";
            // 
            // MonthStat
            // 
            MonthStat.AutoSize = true;
            MonthStat.Font = new Font("Segoe UI", 12F);
            MonthStat.ForeColor = Color.White;
            MonthStat.Location = new Point(176, 61);
            MonthStat.Name = "MonthStat";
            MonthStat.Size = new Size(19, 21);
            MonthStat.TabIndex = 5;
            MonthStat.Text = "0";
            // 
            // WeekStat
            // 
            WeekStat.AutoSize = true;
            WeekStat.Font = new Font("Segoe UI", 12F);
            WeekStat.ForeColor = Color.White;
            WeekStat.Location = new Point(176, 17);
            WeekStat.Name = "WeekStat";
            WeekStat.Size = new Size(19, 21);
            WeekStat.TabIndex = 4;
            WeekStat.Text = "0";
            // 
            // YearStatLabel
            // 
            YearStatLabel.AutoSize = true;
            YearStatLabel.Font = new Font("Segoe UI", 12F);
            YearStatLabel.ForeColor = Color.White;
            YearStatLabel.Location = new Point(12, 101);
            YearStatLabel.Name = "YearStatLabel";
            YearStatLabel.Size = new Size(50, 21);
            YearStatLabel.TabIndex = 3;
            YearStatLabel.Text = "за рік";
            // 
            // MonthStatLabel
            // 
            MonthStatLabel.AutoSize = true;
            MonthStatLabel.Font = new Font("Segoe UI", 12F);
            MonthStatLabel.ForeColor = Color.White;
            MonthStatLabel.Location = new Point(12, 61);
            MonthStatLabel.Name = "MonthStatLabel";
            MonthStatLabel.Size = new Size(77, 21);
            MonthStatLabel.TabIndex = 2;
            MonthStatLabel.Text = "за місяць";
            // 
            // WeekStatLabel
            // 
            WeekStatLabel.AutoSize = true;
            WeekStatLabel.Font = new Font("Segoe UI", 12F);
            WeekStatLabel.ForeColor = Color.White;
            WeekStatLabel.Location = new Point(12, 17);
            WeekStatLabel.Name = "WeekStatLabel";
            WeekStatLabel.Size = new Size(122, 21);
            WeekStatLabel.TabIndex = 1;
            WeekStatLabel.Text = "за цей тиждень";
            // 
            // settingsContainer
            // 
            settingsContainer.BackColor = Color.FromArgb(71, 79, 122);
            settingsContainer.BorderStyle = BorderStyle.FixedSingle;
            settingsContainer.Controls.Add(ThemeLabel);
            settingsContainer.Controls.Add(clear);
            settingsContainer.Controls.Add(ColorThemeComboBox);
            settingsContainer.Location = new Point(1601, 321);
            settingsContainer.Name = "settingsContainer";
            settingsContainer.Size = new Size(252, 92);
            settingsContainer.TabIndex = 24;
            // 
            // ThemeLabel
            // 
            ThemeLabel.AutoSize = true;
            ThemeLabel.Location = new Point(12, 13);
            ThemeLabel.Name = "ThemeLabel";
            ThemeLabel.Size = new Size(75, 15);
            ThemeLabel.TabIndex = 10;
            ThemeLabel.Text = "обрати тему";
            // 
            // clear
            // 
            clear.Location = new Point(12, 39);
            clear.Name = "clear";
            clear.Size = new Size(225, 37);
            clear.TabIndex = 9;
            clear.Text = "видалити всі задачі";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // ColorThemeComboBox
            // 
            ColorThemeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ColorThemeComboBox.FormattingEnabled = true;
            ColorThemeComboBox.Items.AddRange(new object[] { "Default", "CandyMoon", "PolishBeaver", "ForestArcher" });
            ColorThemeComboBox.Location = new Point(100, 10);
            ColorThemeComboBox.Name = "ColorThemeComboBox";
            ColorThemeComboBox.Size = new Size(137, 23);
            ColorThemeComboBox.TabIndex = 1;
            ColorThemeComboBox.SelectedIndexChanged += ColorThemeComboBox_SelectedIndexChanged;
            // 
            // OpenDoneTaskLinkLabel
            // 
            OpenDoneTaskLinkLabel.ActiveLinkColor = Color.White;
            OpenDoneTaskLinkLabel.AutoSize = true;
            OpenDoneTaskLinkLabel.ForeColor = Color.White;
            OpenDoneTaskLinkLabel.LinkColor = Color.White;
            OpenDoneTaskLinkLabel.Location = new Point(311, 962);
            OpenDoneTaskLinkLabel.Name = "OpenDoneTaskLinkLabel";
            OpenDoneTaskLinkLabel.Size = new Size(148, 15);
            OpenDoneTaskLinkLabel.TabIndex = 0;
            OpenDoneTaskLinkLabel.TabStop = true;
            OpenDoneTaskLinkLabel.Text = "відкрити зроблені справи";
            OpenDoneTaskLinkLabel.VisitedLinkColor = Color.White;
            OpenDoneTaskLinkLabel.LinkClicked += OpenDoneTaskLinkLabel_LinkClicked;
            // 
            // BasicTaskListBox
            // 
            BasicTaskListBox.BackColor = Color.FromArgb(255, 208, 236);
            BasicTaskListBox.BorderStyle = BorderStyle.FixedSingle;
            BasicTaskListBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BasicTaskListBox.ForeColor = SystemColors.WindowText;
            BasicTaskListBox.FormattingEnabled = true;
            BasicTaskListBox.ItemHeight = 21;
            BasicTaskListBox.Location = new Point(271, 91);
            BasicTaskListBox.Name = "BasicTaskListBox";
            BasicTaskListBox.Size = new Size(239, 863);
            BasicTaskListBox.TabIndex = 0;
            BasicTaskListBox.DoubleClick += BasicTaskListBox_DoubleClick;
            // 
            // panelCreateTask
            // 
            panelCreateTask.BackColor = Color.FromArgb(129, 104, 157);
            panelCreateTask.BorderStyle = BorderStyle.FixedSingle;
            panelCreateTask.Controls.Add(createTaskLabel);
            panelCreateTask.Location = new Point(12, 64);
            panelCreateTask.Name = "panelCreateTask";
            panelCreateTask.Size = new Size(238, 28);
            panelCreateTask.TabIndex = 27;
            // 
            // createTaskLabel
            // 
            createTaskLabel.AutoSize = true;
            createTaskLabel.ForeColor = Color.White;
            createTaskLabel.Location = new Point(68, 6);
            createTaskLabel.Name = "createTaskLabel";
            createTaskLabel.Size = new Size(98, 15);
            createTaskLabel.TabIndex = 2;
            createTaskLabel.Text = "Створити задачу";
            // 
            // PropertyPanel
            // 
            PropertyPanel.BackColor = Color.FromArgb(71, 79, 122);
            PropertyPanel.BorderStyle = BorderStyle.FixedSingle;
            PropertyPanel.Controls.Add(TimeSettingPanel);
            PropertyPanel.Controls.Add(PlanedCheckBox);
            PropertyPanel.Controls.Add(Location);
            PropertyPanel.Controls.Add(LocationTextBox);
            PropertyPanel.Controls.Add(NoteTextBox);
            PropertyPanel.Controls.Add(Note);
            PropertyPanel.Controls.Add(CreateTaskButton);
            PropertyPanel.Controls.Add(Description);
            PropertyPanel.Controls.Add(DescriptionTextBox);
            PropertyPanel.Controls.Add(label3);
            PropertyPanel.Location = new Point(12, 91);
            PropertyPanel.Name = "PropertyPanel";
            PropertyPanel.Size = new Size(238, 863);
            PropertyPanel.TabIndex = 26;
            // 
            // TimeSettingPanel
            // 
            TimeSettingPanel.BackColor = Color.Transparent;
            TimeSettingPanel.Controls.Add(RepPanel);
            TimeSettingPanel.Controls.Add(RepeatedCheckBox);
            TimeSettingPanel.Controls.Add(dateTimePickerDate);
            TimeSettingPanel.Controls.Add(StartMinuteСomboBox);
            TimeSettingPanel.Controls.Add(Colon);
            TimeSettingPanel.Controls.Add(DurationComboBox);
            TimeSettingPanel.Controls.Add(someText2);
            TimeSettingPanel.Controls.Add(someText1);
            TimeSettingPanel.Controls.Add(StartHourСomboBox);
            TimeSettingPanel.Controls.Add(someText3);
            TimeSettingPanel.Enabled = false;
            TimeSettingPanel.Location = new Point(6, 360);
            TimeSettingPanel.Name = "TimeSettingPanel";
            TimeSettingPanel.Size = new Size(210, 425);
            TimeSettingPanel.TabIndex = 0;
            // 
            // RepPanel
            // 
            RepPanel.Controls.Add(EndDateTimePicker);
            RepPanel.Controls.Add(someText6);
            RepPanel.Controls.Add(FrequencyComboBox);
            RepPanel.Controls.Add(someText5);
            RepPanel.Controls.Add(someText4);
            RepPanel.Enabled = false;
            RepPanel.Location = new Point(3, 230);
            RepPanel.Name = "RepPanel";
            RepPanel.Size = new Size(206, 165);
            RepPanel.TabIndex = 35;
            // 
            // EndDateTimePicker
            // 
            EndDateTimePicker.DropDownAlign = LeftRightAlignment.Right;
            EndDateTimePicker.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EndDateTimePicker.Format = DateTimePickerFormat.Short;
            EndDateTimePicker.Location = new Point(8, 121);
            EndDateTimePicker.Name = "EndDateTimePicker";
            EndDateTimePicker.ShowUpDown = true;
            EndDateTimePicker.Size = new Size(141, 33);
            EndDateTimePicker.TabIndex = 34;
            // 
            // someText6
            // 
            someText6.AutoSize = true;
            someText6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            someText6.ForeColor = Color.White;
            someText6.Location = new Point(7, 93);
            someText6.Name = "someText6";
            someText6.Size = new Size(104, 25);
            someText6.TabIndex = 33;
            someText6.Text = "дата кінця";
            // 
            // FrequencyComboBox
            // 
            FrequencyComboBox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FrequencyComboBox.FormattingEnabled = true;
            FrequencyComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14" });
            FrequencyComboBox.Location = new Point(7, 46);
            FrequencyComboBox.Name = "FrequencyComboBox";
            FrequencyComboBox.Size = new Size(56, 33);
            FrequencyComboBox.TabIndex = 30;
            // 
            // someText5
            // 
            someText5.AutoSize = true;
            someText5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            someText5.ForeColor = Color.White;
            someText5.Location = new Point(69, 49);
            someText5.Name = "someText5";
            someText5.Size = new Size(50, 25);
            someText5.TabIndex = 29;
            someText5.Text = "днів";
            // 
            // someText4
            // 
            someText4.AutoSize = true;
            someText4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            someText4.ForeColor = Color.White;
            someText4.Location = new Point(4, 12);
            someText4.Name = "someText4";
            someText4.Size = new Size(187, 25);
            someText4.TabIndex = 28;
            someText4.Text = "повторювати через";
            // 
            // RepeatedCheckBox
            // 
            RepeatedCheckBox.AutoSize = true;
            RepeatedCheckBox.ForeColor = Color.White;
            RepeatedCheckBox.Location = new Point(5, 212);
            RepeatedCheckBox.Name = "RepeatedCheckBox";
            RepeatedCheckBox.Size = new Size(100, 19);
            RepeatedCheckBox.TabIndex = 34;
            RepeatedCheckBox.Text = "повторювана";
            RepeatedCheckBox.UseVisualStyleBackColor = true;
            RepeatedCheckBox.CheckedChanged += RepeatedCheckBox_CheckedChanged;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.DropDownAlign = LeftRightAlignment.Right;
            dateTimePickerDate.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dateTimePickerDate.Format = DateTimePickerFormat.Short;
            dateTimePickerDate.Location = new Point(6, 162);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.ShowUpDown = true;
            dateTimePickerDate.Size = new Size(141, 33);
            dateTimePickerDate.TabIndex = 32;
            // 
            // StartMinuteСomboBox
            // 
            StartMinuteСomboBox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            StartMinuteСomboBox.FormattingEnabled = true;
            StartMinuteСomboBox.Items.AddRange(new object[] { "00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" });
            StartMinuteСomboBox.Location = new Point(91, 34);
            StartMinuteСomboBox.Name = "StartMinuteСomboBox";
            StartMinuteСomboBox.Size = new Size(56, 33);
            StartMinuteСomboBox.TabIndex = 31;
            // 
            // Colon
            // 
            Colon.AutoSize = true;
            Colon.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Colon.ForeColor = Color.White;
            Colon.Location = new Point(68, 37);
            Colon.Name = "Colon";
            Colon.Size = new Size(17, 25);
            Colon.TabIndex = 33;
            Colon.Text = ":";
            // 
            // DurationComboBox
            // 
            DurationComboBox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DurationComboBox.FormattingEnabled = true;
            DurationComboBox.Items.AddRange(new object[] { "00:10", "00:15", "00:20", "00:30", "00:45", "1:00", "1:30", "2:00", "3:00", "4:00" });
            DurationComboBox.Location = new Point(5, 98);
            DurationComboBox.Name = "DurationComboBox";
            DurationComboBox.Size = new Size(142, 33);
            DurationComboBox.TabIndex = 30;
            // 
            // someText2
            // 
            someText2.AutoSize = true;
            someText2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            someText2.ForeColor = Color.White;
            someText2.Location = new Point(6, 70);
            someText2.Name = "someText2";
            someText2.Size = new Size(106, 25);
            someText2.TabIndex = 25;
            someText2.Text = "тривалість";
            // 
            // someText1
            // 
            someText1.AutoSize = true;
            someText1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            someText1.ForeColor = Color.White;
            someText1.Location = new Point(6, 6);
            someText1.Name = "someText1";
            someText1.Size = new Size(118, 25);
            someText1.TabIndex = 26;
            someText1.Text = "час початку";
            // 
            // StartHourСomboBox
            // 
            StartHourСomboBox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            StartHourСomboBox.FormattingEnabled = true;
            StartHourСomboBox.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" });
            StartHourСomboBox.Location = new Point(6, 34);
            StartHourСomboBox.Name = "StartHourСomboBox";
            StartHourСomboBox.Size = new Size(56, 33);
            StartHourСomboBox.TabIndex = 28;
            // 
            // someText3
            // 
            someText3.AutoSize = true;
            someText3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            someText3.ForeColor = Color.White;
            someText3.Location = new Point(5, 134);
            someText3.Name = "someText3";
            someText3.Size = new Size(139, 25);
            someText3.TabIndex = 27;
            someText3.Text = "дата (початку)";
            // 
            // PlanedCheckBox
            // 
            PlanedCheckBox.AutoSize = true;
            PlanedCheckBox.Location = new Point(13, 342);
            PlanedCheckBox.Name = "PlanedCheckBox";
            PlanedCheckBox.Size = new Size(96, 19);
            PlanedCheckBox.TabIndex = 24;
            PlanedCheckBox.Text = "запланована";
            PlanedCheckBox.UseVisualStyleBackColor = true;
            PlanedCheckBox.CheckedChanged += PlanedCheckBox_CheckedChanged;
            // 
            // Location
            // 
            Location.AutoSize = true;
            Location.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Location.ForeColor = Color.White;
            Location.Location = new Point(5, 256);
            Location.Name = "Location";
            Location.Size = new Size(62, 25);
            Location.TabIndex = 22;
            Location.Text = "місце";
            // 
            // LocationTextBox
            // 
            LocationTextBox.Location = new Point(6, 284);
            LocationTextBox.MaxLength = 50;
            LocationTextBox.Multiline = true;
            LocationTextBox.Name = "LocationTextBox";
            LocationTextBox.Size = new Size(210, 37);
            LocationTextBox.TabIndex = 21;
            // 
            // NoteTextBox
            // 
            NoteTextBox.Location = new Point(5, 102);
            NoteTextBox.MaxLength = 200;
            NoteTextBox.Multiline = true;
            NoteTextBox.Name = "NoteTextBox";
            NoteTextBox.Size = new Size(209, 151);
            NoteTextBox.TabIndex = 20;
            // 
            // Note
            // 
            Note.AutoSize = true;
            Note.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Note.ForeColor = Color.White;
            Note.Location = new Point(5, 74);
            Note.Name = "Note";
            Note.Size = new Size(78, 25);
            Note.TabIndex = 19;
            Note.Text = "замітка";
            // 
            // CreateTaskButton
            // 
            CreateTaskButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CreateTaskButton.Location = new Point(28, 798);
            CreateTaskButton.Name = "CreateTaskButton";
            CreateTaskButton.Size = new Size(175, 48);
            CreateTaskButton.TabIndex = 10;
            CreateTaskButton.Text = "створити задачу";
            CreateTaskButton.UseVisualStyleBackColor = true;
            CreateTaskButton.Click += CreateTaskButton_Click;
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Description.ForeColor = Color.White;
            Description.Location = new Point(6, 6);
            Description.Name = "Description";
            Description.Size = new Size(54, 25);
            Description.TabIndex = 8;
            Description.Text = "опис";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(5, 34);
            DescriptionTextBox.MaxLength = 50;
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(210, 37);
            DescriptionTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 17);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // mainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 37, 68);
            ClientSize = new Size(1904, 993);
            Controls.Add(panelBasikTask);
            Controls.Add(OpenDoneTaskLinkLabel);
            Controls.Add(BasicTaskListBox);
            Controls.Add(panelSettings);
            Controls.Add(panelCreateTask);
            Controls.Add(settingsContainer);
            Controls.Add(PropertyPanel);
            Controls.Add(panelStat);
            Controls.Add(statContainer);
            Controls.Add(TabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "mainWindow";
            Text = "Shchodennik";
            FormClosed += mainWindow_FormClosed;
            TabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            DaySubPanel.ResumeLayout(false);
            panelDayName.ResumeLayout(false);
            panelDayName.PerformLayout();
            tabPage2.ResumeLayout(false);
            weekSubPanel.ResumeLayout(false);
            panelDaysInWeekName.ResumeLayout(false);
            panelDaysInWeekName.PerformLayout();
            tabPage3.ResumeLayout(false);
            MonthSubPanel.ResumeLayout(false);
            panelDaysInMonthName.ResumeLayout(false);
            panelDaysInMonthName.PerformLayout();
            panelSettings.ResumeLayout(false);
            panelSettings.PerformLayout();
            panelBasikTask.ResumeLayout(false);
            panelBasikTask.PerformLayout();
            panelStat.ResumeLayout(false);
            panelStat.PerformLayout();
            statContainer.ResumeLayout(false);
            statContainer.PerformLayout();
            settingsContainer.ResumeLayout(false);
            settingsContainer.PerformLayout();
            panelCreateTask.ResumeLayout(false);
            panelCreateTask.PerformLayout();
            PropertyPanel.ResumeLayout(false);
            PropertyPanel.PerformLayout();
            TimeSettingPanel.ResumeLayout(false);
            TimeSettingPanel.PerformLayout();
            RepPanel.ResumeLayout(false);
            RepPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage1;
        private Panel DaySubPanel;
        private DateTimePicker MainDatePicker;
        private Panel DayPanel;
        private Button clear;
        private Panel TimeScalePanel;
        private Panel weekSubPanel;
        private Panel WeekPanel;
        private DateTimePicker WeekDateTimePicker;
        private Panel MonthSubPanel;
        private Label Day6LabelMonth;
        private Label Day5LabelMonth;
        private Label Day4LabelMonth;
        private Label Day3LabelMonth;
        private Label Day2LabelMonth;
        private Label Day1LabelMonth;
        private TableLayoutPanel MonthTableLayoutPanel;
        private DateTimePicker MonthDateTimePicker;
        private Panel panelDaysInMonthName;
        private Panel panelBasikTask;
        private Label BasicTaskLabel;
        private Panel panelSettings;
        private Label settingsLabel;
        private Panel panelStat;
        private Label statLabel;
        private Panel statContainer;
        private Label YearStat;
        private Label MonthStat;
        private Label WeekStat;
        private Label YearStatLabel;
        private Label MonthStatLabel;
        private Label WeekStatLabel;
        private Panel settingsContainer;
        private Panel panelDaysInWeekName;
        private Label Day6Label;
        private Label Day1Label;
        private Label Day0Label;
        private Label Day5Label;
        private Label Day2Label;
        private Label Day3Label;
        private Label Day4Label;
        private Panel TimeScalePanelForWeek;
        private Panel panelCreateTask;
        private Label createTaskLabel;
        private Panel PropertyPanel;
        private Panel TimeSettingPanel;
        private DateTimePicker dateTimePickerDate;
        private ComboBox StartMinuteСomboBox;
        private Label Colon;
        private ComboBox DurationComboBox;
        private Label someText2;
        private Label someText1;
        private ComboBox StartHourСomboBox;
        private Label someText3;
        private CheckBox PlanedCheckBox;
        private Label Location;
        private TextBox LocationTextBox;
        private TextBox NoteTextBox;
        private Label Note;
        private Button CreateTaskButton;
        private Label Description;
        private TextBox DescriptionTextBox;
        private Label label3;
        private Label Day0LabelMonth;
        private Label label10;
        private Panel panelDayName;
        private Label DayNameLabel;
        public ListBox BasicTaskListBox;
        public TabControl TabControl;
        private Panel RepPanel;
        private Label someText5;
        private Label someText4;
        private CheckBox RepeatedCheckBox;
        private DateTimePicker EndDateTimePicker;
        private Label someText6;
        private ComboBox FrequencyComboBox;
        private LinkLabel OpenDoneTaskLinkLabel;
        private ComboBox ColorThemeComboBox;
        private Button DayForwardButton;
        private Button DayBackwardButton;
        private Button WeekForwardButton;
        private Button WeekBackWardButton;
        private Button MonthForwardButton;
        private Button MonthBackwardButton;
        private Label ThemeLabel;
    }
}
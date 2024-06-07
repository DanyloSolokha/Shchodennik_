using static UniversalHelper;

namespace Schodennik
{
    partial class EditForm
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
            Location = new Label();
            LocationTextBox = new TextBox();
            NoteTextBox = new TextBox();
            Note = new Label();
            EditTaskButton = new Button();
            Description = new Label();
            DescriptionTextBox = new TextBox();
            DeleteButton = new Button();
            TimeSettingPanel = new Panel();
            EndDateTimePicker = new DateTimePicker();
            RepPanel = new Panel();
            ShowLastLinkLabel = new LinkLabel();
            ShowFirstLinkLabel = new LinkLabel();
            FrequencyComboBox = new ComboBox();
            label2 = new Label();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            dateTimePickerDate = new DateTimePicker();
            StartMinuteСomboBox = new ComboBox();
            Colon = new Label();
            DurationComboBox = new ComboBox();
            Duration = new Label();
            label18 = new Label();
            StartHourСomboBox = new ComboBox();
            Date = new Label();
            RepeatedCheckBox = new CheckBox();
            SubTasksLinkLabel = new LinkLabel();
            PlanedCheckBox = new CheckBox();
            DoneCheckBox = new CheckBox();
            TimeSettingPanel.SuspendLayout();
            RepPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Location
            // 
            Location.AutoSize = true;
            Location.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Location.Location = new Point(11, 259);
            Location.Name = "Location";
            Location.Size = new Size(62, 25);
            Location.TabIndex = 37;
            Location.Text = "місце";
            // 
            // LocationTextBox
            // 
            LocationTextBox.Location = new Point(11, 287);
            LocationTextBox.MaxLength = 50;
            LocationTextBox.Multiline = true;
            LocationTextBox.Name = "LocationTextBox";
            LocationTextBox.Size = new Size(209, 37);
            LocationTextBox.TabIndex = 36;
            // 
            // NoteTextBox
            // 
            NoteTextBox.Location = new Point(11, 105);
            NoteTextBox.MaxLength = 200;
            NoteTextBox.Multiline = true;
            NoteTextBox.Name = "NoteTextBox";
            NoteTextBox.Size = new Size(209, 151);
            NoteTextBox.TabIndex = 35;
            // 
            // Note
            // 
            Note.AutoSize = true;
            Note.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Note.Location = new Point(11, 77);
            Note.Name = "Note";
            Note.Size = new Size(78, 25);
            Note.TabIndex = 34;
            Note.Text = "замітка";
            // 
            // EditTaskButton
            // 
            EditTaskButton.BackColor = Color.White;
            EditTaskButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EditTaskButton.Location = new Point(277, 491);
            EditTaskButton.Name = "EditTaskButton";
            EditTaskButton.Size = new Size(175, 48);
            EditTaskButton.TabIndex = 28;
            EditTaskButton.Text = "зберегти";
            EditTaskButton.UseVisualStyleBackColor = false;
            EditTaskButton.Click += EditTaskButton_Click;
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Description.Location = new Point(12, 9);
            Description.Name = "Description";
            Description.Size = new Size(54, 25);
            Description.TabIndex = 27;
            Description.Text = "опис";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(12, 37);
            DescriptionTextBox.MaxLength = 50;
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(209, 37);
            DescriptionTextBox.TabIndex = 26;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.White;
            DeleteButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DeleteButton.ForeColor = Color.Red;
            DeleteButton.Location = new Point(277, 437);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(175, 48);
            DeleteButton.TabIndex = 38;
            DeleteButton.Text = "видалити";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // TimeSettingPanel
            // 
            TimeSettingPanel.BorderStyle = BorderStyle.FixedSingle;
            TimeSettingPanel.Controls.Add(EndDateTimePicker);
            TimeSettingPanel.Controls.Add(RepPanel);
            TimeSettingPanel.Controls.Add(dateTimePickerDate);
            TimeSettingPanel.Controls.Add(StartMinuteСomboBox);
            TimeSettingPanel.Controls.Add(Colon);
            TimeSettingPanel.Controls.Add(DurationComboBox);
            TimeSettingPanel.Controls.Add(Duration);
            TimeSettingPanel.Controls.Add(label18);
            TimeSettingPanel.Controls.Add(StartHourСomboBox);
            TimeSettingPanel.Controls.Add(Date);
            TimeSettingPanel.Enabled = false;
            TimeSettingPanel.Location = new Point(271, 63);
            TimeSettingPanel.Name = "TimeSettingPanel";
            TimeSettingPanel.Size = new Size(458, 208);
            TimeSettingPanel.TabIndex = 39;
            // 
            // EndDateTimePicker
            // 
            EndDateTimePicker.DropDownAlign = LeftRightAlignment.Right;
            EndDateTimePicker.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EndDateTimePicker.Format = DateTimePickerFormat.Short;
            EndDateTimePicker.Location = new Point(232, 32);
            EndDateTimePicker.Name = "EndDateTimePicker";
            EndDateTimePicker.ShowUpDown = true;
            EndDateTimePicker.Size = new Size(141, 33);
            EndDateTimePicker.TabIndex = 34;
            // 
            // RepPanel
            // 
            RepPanel.BorderStyle = BorderStyle.FixedSingle;
            RepPanel.Controls.Add(ShowLastLinkLabel);
            RepPanel.Controls.Add(ShowFirstLinkLabel);
            RepPanel.Controls.Add(FrequencyComboBox);
            RepPanel.Controls.Add(label2);
            RepPanel.Controls.Add(label7);
            RepPanel.Controls.Add(label6);
            RepPanel.Controls.Add(label8);
            RepPanel.Enabled = false;
            RepPanel.Location = new Point(226, -1);
            RepPanel.Name = "RepPanel";
            RepPanel.Size = new Size(232, 212);
            RepPanel.TabIndex = 38;
            // 
            // ShowLastLinkLabel
            // 
            ShowLastLinkLabel.ActiveLinkColor = Color.Black;
            ShowLastLinkLabel.AutoSize = true;
            ShowLastLinkLabel.DisabledLinkColor = Color.Black;
            ShowLastLinkLabel.Enabled = false;
            ShowLastLinkLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ShowLastLinkLabel.LinkColor = Color.Black;
            ShowLastLinkLabel.Location = new Point(6, 173);
            ShowLastLinkLabel.Name = "ShowLastLinkLabel";
            ShowLastLinkLabel.Size = new Size(217, 21);
            ShowLastLinkLabel.TabIndex = 39;
            ShowLastLinkLabel.TabStop = true;
            ShowLastLinkLabel.Text = "показати останню у ганцюгу";
            ShowLastLinkLabel.VisitedLinkColor = Color.Black;
            ShowLastLinkLabel.LinkClicked += ShowLastLinkLabel_LinkClicked;
            // 
            // ShowFirstLinkLabel
            // 
            ShowFirstLinkLabel.ActiveLinkColor = Color.Black;
            ShowFirstLinkLabel.AutoSize = true;
            ShowFirstLinkLabel.DisabledLinkColor = Color.Black;
            ShowFirstLinkLabel.Enabled = false;
            ShowFirstLinkLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ShowFirstLinkLabel.LinkColor = Color.Black;
            ShowFirstLinkLabel.Location = new Point(6, 152);
            ShowFirstLinkLabel.Name = "ShowFirstLinkLabel";
            ShowFirstLinkLabel.Size = new Size(202, 21);
            ShowFirstLinkLabel.TabIndex = 38;
            ShowFirstLinkLabel.TabStop = true;
            ShowFirstLinkLabel.Text = "показати першу у ганцюгу";
            ShowFirstLinkLabel.VisitedLinkColor = Color.Black;
            ShowFirstLinkLabel.LinkClicked += ShowFirstLinkLabel_LinkClicked;
            
            






            // FrequencyComboBox
            // 
            FrequencyComboBox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FrequencyComboBox.FormattingEnabled = true;
            FrequencyComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14" });
            FrequencyComboBox.Location = new Point(69, 95);
            FrequencyComboBox.Name = "FrequencyComboBox";
            FrequencyComboBox.Size = new Size(56, 33);
            FrequencyComboBox.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(6, 98);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 37;
            label2.Text = "через";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(128, 98);
            label7.Name = "label7";
            label7.Size = new Size(50, 25);
            label7.TabIndex = 29;
            label7.Text = "днів";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(6, 70);
            label6.Name = "label6";
            label6.Size = new Size(131, 25);
            label6.TabIndex = 28;
            label6.Text = "повторювати";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(6, 5);
            label8.Name = "label8";
            label8.Size = new Size(104, 25);
            label8.TabIndex = 33;
            label8.Text = "дата кінця";
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.DropDownAlign = LeftRightAlignment.Right;
            dateTimePickerDate.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dateTimePickerDate.Format = DateTimePickerFormat.Short;
            dateTimePickerDate.Location = new Point(6, 161);
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
            StartMinuteСomboBox.Location = new Point(91, 33);
            StartMinuteСomboBox.Name = "StartMinuteСomboBox";
            StartMinuteСomboBox.Size = new Size(56, 33);
            StartMinuteСomboBox.TabIndex = 31;
            // 
            // Colon
            // 
            Colon.AutoSize = true;
            Colon.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Colon.Location = new Point(68, 36);
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
            DurationComboBox.Location = new Point(5, 97);
            DurationComboBox.Name = "DurationComboBox";
            DurationComboBox.Size = new Size(142, 33);
            DurationComboBox.TabIndex = 30;
            // 
            // Duration
            // 
            Duration.AutoSize = true;
            Duration.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Duration.Location = new Point(6, 69);
            Duration.Name = "Duration";
            Duration.Size = new Size(106, 25);
            Duration.TabIndex = 25;
            Duration.Text = "тривалість";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label18.Location = new Point(6, 5);
            label18.Name = "label18";
            label18.Size = new Size(118, 25);
            label18.TabIndex = 26;
            label18.Text = "час початку";
            // 
            // StartHourСomboBox
            // 
            StartHourСomboBox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            StartHourСomboBox.FormattingEnabled = true;
            StartHourСomboBox.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" });
            StartHourСomboBox.Location = new Point(6, 33);
            StartHourСomboBox.Name = "StartHourСomboBox";
            StartHourСomboBox.Size = new Size(56, 33);
            StartHourСomboBox.TabIndex = 28;
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Date.Location = new Point(5, 133);
            Date.Name = "Date";
            Date.Size = new Size(51, 25);
            Date.TabIndex = 27;
            Date.Text = "дата";
            // 
            // RepeatedCheckBox
            // 
            RepeatedCheckBox.AutoSize = true;
            RepeatedCheckBox.Enabled = false;
            RepeatedCheckBox.Location = new Point(504, 37);
            RepeatedCheckBox.Name = "RepeatedCheckBox";
            RepeatedCheckBox.Size = new Size(100, 19);
            RepeatedCheckBox.TabIndex = 36;
            RepeatedCheckBox.Text = "повторювана";
            RepeatedCheckBox.UseVisualStyleBackColor = true;
            RepeatedCheckBox.CheckedChanged += RepeatedCheckBox_CheckedChanged;
            // 
            // SubTasksLinkLabel
            // 
            SubTasksLinkLabel.ActiveLinkColor = Color.Black;
            SubTasksLinkLabel.AutoSize = true;
            SubTasksLinkLabel.DisabledLinkColor = Color.Black;
            SubTasksLinkLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SubTasksLinkLabel.LinkColor = Color.Black;
            SubTasksLinkLabel.Location = new Point(10, 385);
            SubTasksLinkLabel.Name = "SubTasksLinkLabel";
            SubTasksLinkLabel.Size = new Size(86, 21);
            SubTasksLinkLabel.TabIndex = 34;
            SubTasksLinkLabel.TabStop = true;
            SubTasksLinkLabel.Text = "підзадачі...";
            SubTasksLinkLabel.VisitedLinkColor = Color.Black;
            SubTasksLinkLabel.LinkClicked += SubTasksLinkLabel_LinkClicked;
            // 
            // PlanedCheckBox
            // 
            PlanedCheckBox.AutoSize = true;
            PlanedCheckBox.Location = new Point(271, 37);
            PlanedCheckBox.Name = "PlanedCheckBox";
            PlanedCheckBox.Size = new Size(96, 19);
            PlanedCheckBox.TabIndex = 40;
            PlanedCheckBox.Text = "запланована";
            PlanedCheckBox.UseVisualStyleBackColor = true;
            PlanedCheckBox.CheckedChanged += PlanedCheckBox_CheckedChanged;
            // 
            // DoneCheckBox
            // 
            DoneCheckBox.AutoSize = true;
            DoneCheckBox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DoneCheckBox.Location = new Point(11, 353);
            DoneCheckBox.Name = "DoneCheckBox";
            DoneCheckBox.Size = new Size(116, 29);
            DoneCheckBox.TabIndex = 41;
            DoneCheckBox.Text = "виконана";
            DoneCheckBox.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(756, 561);
            Controls.Add(SubTasksLinkLabel);
            Controls.Add(RepeatedCheckBox);
            Controls.Add(DoneCheckBox);
            Controls.Add(TimeSettingPanel);
            Controls.Add(PlanedCheckBox);
            Controls.Add(DeleteButton);
            Controls.Add(Location);
            Controls.Add(LocationTextBox);
            Controls.Add(NoteTextBox);
            Controls.Add(Note);
            Controls.Add(EditTaskButton);
            Controls.Add(Description);
            Controls.Add(DescriptionTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "EditForm";
            ShowInTaskbar = false;
            Text = "редагувати задачу";
            FormClosed += EditForm_FormClosed;
            Load += EditForm_Load;
            TimeSettingPanel.ResumeLayout(false);
            TimeSettingPanel.PerformLayout();
            RepPanel.ResumeLayout(false);
            RepPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Location;
        private TextBox LocationTextBox;
        private TextBox NoteTextBox;
        private Label Note;
        private Button EditTaskButton;
        private Label Description;
        private TextBox DescriptionTextBox;
        private Button DeleteButton;
        private Panel TimeSettingPanel;
        private DateTimePicker dateTimePickerDate;
        private ComboBox StartMinuteСomboBox;
        private Label Colon;
        private ComboBox DurationComboBox;
        private Label Duration;
        private Label label18;
        private ComboBox StartHourСomboBox;
        private Label Date;
        private CheckBox PlanedCheckBox;
        private LinkLabel SubTasksLinkLabel;
        private CheckBox DoneCheckBox;
        private CheckBox RepeatedCheckBox;
        private DateTimePicker EndDateTimePicker;
        private Panel RepPanel;
        private LinkLabel ShowLastLinkLabel;
        private LinkLabel ShowFirstLinkLabel;
        private ComboBox FrequencyComboBox;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label8;
    }
}
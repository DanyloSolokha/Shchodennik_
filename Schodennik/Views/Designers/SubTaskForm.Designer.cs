namespace Schodennik
{
    partial class SubTaskForm
    {
        
        
        
        
        
        
        // <summary>
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
            SubTaskListBox = new ListBox();
            label21 = new Label();
            LocationTextBox = new TextBox();
            NoteTextBox = new TextBox();
            Note = new Label();
            Description = new Label();
            DescriptionTextBox = new TextBox();
            EditTaskButton = new Button();
            CreateSubTaskButton = new Button();
            SuspendLayout();
            // 
            // SubTaskListBox
            // 
            SubTaskListBox.BackColor = Color.SeaShell;
            SubTaskListBox.BorderStyle = BorderStyle.FixedSingle;
            SubTaskListBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SubTaskListBox.ForeColor = SystemColors.WindowText;
            SubTaskListBox.FormattingEnabled = true;
            SubTaskListBox.ItemHeight = 21;
            SubTaskListBox.Location = new Point(265, 10);
            SubTaskListBox.Name = "SubTaskListBox";
            SubTaskListBox.Size = new Size(239, 464);
            SubTaskListBox.TabIndex = 1;
            SubTaskListBox.DoubleClick += ListBox_DoubleClick;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label21.Location = new Point(11, 262);
            label21.Name = "label21";
            label21.Size = new Size(62, 25);
            label21.TabIndex = 43;
            label21.Text = "місце";
            // 
            // LocationTextBox
            // 
            LocationTextBox.Location = new Point(11, 290);
            LocationTextBox.MaxLength = 50;
            LocationTextBox.Multiline = true;
            LocationTextBox.Name = "LocationTextBox";
            LocationTextBox.Size = new Size(209, 37);
            LocationTextBox.TabIndex = 42;
            // 
            // NoteTextBox
            // 
            NoteTextBox.Location = new Point(11, 108);
            NoteTextBox.MaxLength = 200;
            NoteTextBox.Multiline = true;
            NoteTextBox.Name = "NoteTextBox";
            NoteTextBox.Size = new Size(209, 151);
            NoteTextBox.TabIndex = 41;
            // 
            // Note
            // 
            Note.AutoSize = true;
            Note.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Note.Location = new Point(11, 80);
            Note.Name = "Note";
            Note.Size = new Size(78, 25);
            Note.TabIndex = 40;
            Note.Text = "замітка";
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Description.Location = new Point(12, 12);
            Description.Name = "Description";
            Description.Size = new Size(54, 25);
            Description.TabIndex = 39;
            Description.Text = "опис";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(12, 40);
            DescriptionTextBox.MaxLength = 50;
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(209, 37);
            DescriptionTextBox.TabIndex = 38;
            // 
            // EditTaskButton
            // 
            EditTaskButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EditTaskButton.Location = new Point(12, 413);
            EditTaskButton.Name = "EditTaskButton";
            EditTaskButton.Size = new Size(209, 48);
            EditTaskButton.TabIndex = 44;
            EditTaskButton.Text = "зберегти";
            EditTaskButton.UseVisualStyleBackColor = true;
            EditTaskButton.Click += EditTaskButton_Click;
            // 
            // CreateSubTaskButton
            // 
            CreateSubTaskButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CreateSubTaskButton.Location = new Point(12, 344);
            CreateSubTaskButton.Name = "CreateSubTaskButton";
            CreateSubTaskButton.Size = new Size(209, 54);
            CreateSubTaskButton.TabIndex = 45;
            CreateSubTaskButton.Text = "створити підзадачу";
            CreateSubTaskButton.UseVisualStyleBackColor = true;
            CreateSubTaskButton.Click += CreateSubTaskButton_Click;
            // 
            // SubTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(538, 482);
            Controls.Add(CreateSubTaskButton);
            Controls.Add(EditTaskButton);
            Controls.Add(label21);
            Controls.Add(LocationTextBox);
            Controls.Add(NoteTextBox);
            Controls.Add(Note);
            Controls.Add(Description);
            Controls.Add(DescriptionTextBox);
            Controls.Add(SubTaskListBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "SubTaskForm";
            Text = "підзадачі";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox SubTaskListBox;
        private Label label21;
        private TextBox LocationTextBox;
        private TextBox NoteTextBox;
        private Label Note;
        private Label Description;
        private TextBox DescriptionTextBox;
        private Button EditTaskButton;
        private Button CreateSubTaskButton;
    }
}
namespace Schodennik
{
    partial class SimplifiedEditForm
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
            DoneCheckBox = new CheckBox();
            linkLabel1 = new LinkLabel();
            DeleteButton = new Button();
            label21 = new Label();
            LocationTextBox = new TextBox();
            NoteTextBox = new TextBox();
            Note = new Label();
            EditTaskButton = new Button();
            Description = new Label();
            DescriptionTextBox = new TextBox();
            SuspendLayout();
            // 
            // DoneCheckBox
            // 
            DoneCheckBox.AutoSize = true;
            DoneCheckBox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DoneCheckBox.Location = new Point(46, 379);
            DoneCheckBox.Name = "DoneCheckBox";
            DoneCheckBox.Size = new Size(116, 29);
            DoneCheckBox.TabIndex = 52;
            DoneCheckBox.Text = "виконана";
            DoneCheckBox.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.Black;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(9, 334);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(86, 21);
            linkLabel1.TabIndex = 34;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "підзадачі...";
            linkLabel1.VisitedLinkColor = Color.Black;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DeleteButton.ForeColor = Color.Red;
            DeleteButton.Location = new Point(19, 476);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(175, 48);
            DeleteButton.TabIndex = 49;
            DeleteButton.Text = "видалити";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label21.Location = new Point(8, 256);
            label21.Name = "label21";
            label21.Size = new Size(62, 25);
            label21.TabIndex = 48;
            label21.Text = "місце";
            // 
            // LocationTextBox
            // 
            LocationTextBox.Location = new Point(8, 284);
            LocationTextBox.MaxLength = 50;
            LocationTextBox.Multiline = true;
            LocationTextBox.Name = "LocationTextBox";
            LocationTextBox.Size = new Size(209, 37);
            LocationTextBox.TabIndex = 47;
            // 
            // NoteTextBox
            // 
            NoteTextBox.Location = new Point(8, 102);
            NoteTextBox.MaxLength = 200;
            NoteTextBox.Multiline = true;
            NoteTextBox.Name = "NoteTextBox";
            NoteTextBox.Size = new Size(209, 151);
            NoteTextBox.TabIndex = 46;
            // 
            // Note
            // 
            Note.AutoSize = true;
            Note.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Note.Location = new Point(8, 74);
            Note.Name = "Note";
            Note.Size = new Size(78, 25);
            Note.TabIndex = 45;
            Note.Text = "замітка";
            // 
            // EditTaskButton
            // 
            EditTaskButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EditTaskButton.Location = new Point(19, 413);
            EditTaskButton.Name = "EditTaskButton";
            EditTaskButton.Size = new Size(175, 48);
            EditTaskButton.TabIndex = 44;
            EditTaskButton.Text = "зберегти";
            EditTaskButton.UseVisualStyleBackColor = true;
            EditTaskButton.Click += EditTaskButton_Click;
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Description.Location = new Point(9, 6);
            Description.Name = "Description";
            Description.Size = new Size(54, 25);
            Description.TabIndex = 43;
            Description.Text = "опис";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(9, 34);
            DescriptionTextBox.MaxLength = 50;
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(209, 37);
            DescriptionTextBox.TabIndex = 42;
            // 
            // SimplifiedEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(228, 543);
            Controls.Add(linkLabel1);
            Controls.Add(DoneCheckBox);
            Controls.Add(DeleteButton);
            Controls.Add(label21);
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
            Name = "SimplifiedEditForm";
            Text = "редагувати підзадачу";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox DoneCheckBox;
        private LinkLabel linkLabel1;
        private Button DeleteButton;
        private Label label21;
        private TextBox LocationTextBox;
        private TextBox NoteTextBox;
        private Label Note;
        private Button EditTaskButton;
        private Label Description;
        private TextBox DescriptionTextBox;
    }
}
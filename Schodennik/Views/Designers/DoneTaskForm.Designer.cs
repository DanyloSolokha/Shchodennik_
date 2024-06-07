namespace Schodennik
{
    partial class DoneTaskForm
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
            DoneBasicTaskListBox = new ListBox();
            SuspendLayout();
            // 
            // DoneBasicTaskListBox
            // 
            DoneBasicTaskListBox.BackColor = Color.SeaShell;
            DoneBasicTaskListBox.BorderStyle = BorderStyle.FixedSingle;
            DoneBasicTaskListBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DoneBasicTaskListBox.ForeColor = SystemColors.WindowText;
            DoneBasicTaskListBox.FormattingEnabled = true;
            DoneBasicTaskListBox.ItemHeight = 21;
            DoneBasicTaskListBox.Location = new Point(12, 12);
            DoneBasicTaskListBox.Name = "DoneBasicTaskListBox";
            DoneBasicTaskListBox.Size = new Size(239, 674);
            DoneBasicTaskListBox.TabIndex = 2;
            DoneBasicTaskListBox.SelectedIndexChanged += SubTaskListBox_SelectedIndexChanged;
            DoneBasicTaskListBox.DoubleClick += DoneBasicTaskListBox_DoubleClick;
            // 
            // DoneTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(264, 701);
            Controls.Add(DoneBasicTaskListBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DoneTaskForm";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "DoneTaskForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox DoneBasicTaskListBox;
    }
}
namespace Schodennik
{
    partial class CalendarCell
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dayNumberLabel = new Label();
            durationNumberLabel = new Label();
            numberOfTaskLabel = new LinkLabel();
            SuspendLayout();
            // 
            // dayNumberLabel
            // 
            dayNumberLabel.AutoSize = true;
            dayNumberLabel.Location = new Point(3, 0);
            dayNumberLabel.Name = "dayNumberLabel";
            dayNumberLabel.Size = new Size(19, 15);
            dayNumberLabel.TabIndex = 0;
            dayNumberLabel.Text = "31";
            // 
            // durationNumberLabel
            // 
            durationNumberLabel.AutoSize = true;
            durationNumberLabel.Location = new Point(3, 120);
            durationNumberLabel.Name = "durationNumberLabel";
            durationNumberLabel.Size = new Size(89, 15);
            durationNumberLabel.TabIndex = 1;
            durationNumberLabel.Text = "розплановано:";
            // 
            // numberOfTaskLabel
            // 
            numberOfTaskLabel.ActiveLinkColor = Color.Black;
            numberOfTaskLabel.Anchor = AnchorStyles.Right;
            numberOfTaskLabel.AutoSize = true;
            numberOfTaskLabel.BackColor = Color.Transparent;
            numberOfTaskLabel.Font = new Font("Segoe UI Semilight", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberOfTaskLabel.ForeColor = Color.Black;
            numberOfTaskLabel.LinkColor = Color.Black;
            numberOfTaskLabel.Location = new Point(3, 47);
            numberOfTaskLabel.Name = "numberOfTaskLabel";
            numberOfTaskLabel.Size = new Size(66, 45);
            numberOfTaskLabel.TabIndex = 2;
            numberOfTaskLabel.TabStop = true;
            numberOfTaskLabel.Text = "0/0";
            numberOfTaskLabel.TextAlign = ContentAlignment.MiddleCenter;
            numberOfTaskLabel.VisitedLinkColor = Color.Black;
            numberOfTaskLabel.LinkClicked += numberOfTaskLabel_LinkClicked;
            // 
            // CallendarCell
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(numberOfTaskLabel);
            Controls.Add(durationNumberLabel);
            Controls.Add(dayNumberLabel);
            Name = "CallendarCell";
            Size = new Size(137, 135);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dayNumberLabel;
        private Label durationNumberLabel;
        private LinkLabel numberOfTaskLabel;
    }
}

namespace Schodennik
{
    partial class SelectModeForm
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
            SecondModeButton = new Button();
            FirstModeButton = new Button();
            ThirdModeButton = new Button();
            FourthModeButton = new Button();
            SuspendLayout();
            // 
            // SecondModeButton
            // 
            SecondModeButton.BackColor = Color.White;
            SecondModeButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SecondModeButton.Location = new Point(12, 66);
            SecondModeButton.Name = "SecondModeButton";
            SecondModeButton.Size = new Size(348, 48);
            SecondModeButton.TabIndex = 29;
            SecondModeButton.Text = "всі наступні (тільки час)";
            SecondModeButton.UseVisualStyleBackColor = false;
            SecondModeButton.Click += AllForwardButton_Click;
            // 
            // FirstModeButton
            // 
            FirstModeButton.BackColor = Color.White;
            FirstModeButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FirstModeButton.Location = new Point(12, 12);
            FirstModeButton.Name = "FirstModeButton";
            FirstModeButton.Size = new Size(348, 48);
            FirstModeButton.TabIndex = 30;
            FirstModeButton.Text = "тільки цю";
            FirstModeButton.UseVisualStyleBackColor = false;
            FirstModeButton.Click += OnlyThisButton_Click;
            // 
            // ThirdModeButton
            // 
            ThirdModeButton.BackColor = Color.White;
            ThirdModeButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ThirdModeButton.Location = new Point(12, 120);
            ThirdModeButton.Name = "ThirdModeButton";
            ThirdModeButton.Size = new Size(348, 48);
            ThirdModeButton.TabIndex = 31;
            ThirdModeButton.Text = "всі наступні (зміст і час)";
            ThirdModeButton.UseVisualStyleBackColor = false;
            ThirdModeButton.Click += button1_Click;
            // 
            // FourthModeButton
            // 
            FourthModeButton.BackColor = Color.White;
            FourthModeButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FourthModeButton.Location = new Point(12, 174);
            FourthModeButton.Name = "FourthModeButton";
            FourthModeButton.Size = new Size(348, 48);
            FourthModeButton.TabIndex = 32;
            FourthModeButton.Text = "всі наступні (тільки зміст)";
            FourthModeButton.UseVisualStyleBackColor = false;
            FourthModeButton.Click += AllForwardContentOnlyButton_Click;
            // 
            // SelectModeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(373, 242);
            Controls.Add(FourthModeButton);
            Controls.Add(ThirdModeButton);
            Controls.Add(FirstModeButton);
            Controls.Add(SecondModeButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "SelectModeForm";
            Text = "режим перенесення";
            Load += SelectModeForm_Load;
            ResumeLayout(false);
        }

        #endregion

        public Button SecondModeButton;
        public Button FirstModeButton;
        public Button ThirdModeButton;
        public Button FourthModeButton;
    }
}
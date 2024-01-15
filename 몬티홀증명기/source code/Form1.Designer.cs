namespace mont
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AnalyzeButton = new Button();
            AnalyzeNumTextBox = new TextBox();
            TotalValue = new Label();
            LoseByChange = new Label();
            WinByChange = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            LosePercentage = new Label();
            WinPercentage = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // AnalyzeButton
            // 
            AnalyzeButton.Location = new Point(485, 329);
            AnalyzeButton.Name = "AnalyzeButton";
            AnalyzeButton.Size = new Size(75, 23);
            AnalyzeButton.TabIndex = 0;
            AnalyzeButton.Text = "Analyze";
            AnalyzeButton.UseVisualStyleBackColor = true;
            AnalyzeButton.Click += AnalyzeButton_Click;
            // 
            // AnalyzeNumTextBox
            // 
            AnalyzeNumTextBox.Location = new Point(369, 300);
            AnalyzeNumTextBox.Name = "AnalyzeNumTextBox";
            AnalyzeNumTextBox.Size = new Size(303, 23);
            AnalyzeNumTextBox.TabIndex = 1;
            // 
            // TotalValue
            // 
            TotalValue.Font = new Font("맑은 고딕", 24F);
            TotalValue.Location = new Point(172, 216);
            TotalValue.Name = "TotalValue";
            TotalValue.Size = new Size(500, 50);
            TotalValue.TabIndex = 2;
            TotalValue.Text = "label1";
            TotalValue.Click += label1_Click;
            // 
            // LoseByChange
            // 
            LoseByChange.Font = new Font("맑은 고딕", 24F);
            LoseByChange.Location = new Point(172, 127);
            LoseByChange.Name = "LoseByChange";
            LoseByChange.Size = new Size(500, 50);
            LoseByChange.TabIndex = 3;
            LoseByChange.Text = "label1";
            LoseByChange.Click += LoseByChange_Click;
            // 
            // WinByChange
            // 
            WinByChange.Font = new Font("맑은 고딕", 24F);
            WinByChange.Location = new Point(172, 26);
            WinByChange.Name = "WinByChange";
            WinByChange.Size = new Size(500, 50);
            WinByChange.TabIndex = 4;
            WinByChange.Text = "label1";
            WinByChange.Click += WinByChange_Click;
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 61);
            label1.TabIndex = 5;
            label1.Text = "바꾸고 이김";
            // 
            // label2
            // 
            label2.Location = new Point(12, 116);
            label2.Name = "label2";
            label2.Size = new Size(139, 61);
            label2.TabIndex = 6;
            label2.Text = "바꾸고 짐";
            // 
            // label3
            // 
            label3.Location = new Point(12, 205);
            label3.Name = "label3";
            label3.Size = new Size(139, 61);
            label3.TabIndex = 7;
            label3.Text = "총 분석 횟수";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 300);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 8;
            label4.Text = "우승 확률";
            // 
            // LosePercentage
            // 
            LosePercentage.AutoSize = true;
            LosePercentage.Location = new Point(100, 332);
            LosePercentage.Name = "LosePercentage";
            LosePercentage.Size = new Size(59, 15);
            LosePercentage.TabIndex = 9;
            LosePercentage.Text = "패배 확률";
            LosePercentage.Click += label5_Click;
            // 
            // WinPercentage
            // 
            WinPercentage.AutoSize = true;
            WinPercentage.Location = new Point(101, 300);
            WinPercentage.Name = "WinPercentage";
            WinPercentage.Size = new Size(59, 15);
            WinPercentage.TabIndex = 10;
            WinPercentage.Text = "우승 확률";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 332);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 11;
            label5.Text = "패배 확률";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(label5);
            Controls.Add(WinPercentage);
            Controls.Add(LosePercentage);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(WinByChange);
            Controls.Add(LoseByChange);
            Controls.Add(TotalValue);
            Controls.Add(AnalyzeNumTextBox);
            Controls.Add(AnalyzeButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AnalyzeButton;
        private TextBox AnalyzeNumTextBox;
        private Label TotalValue;
        private Label LoseByChange;
        private Label WinByChange;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label LosePercentage;
        private Label WinPercentage;
        private Label label5;
    }
}

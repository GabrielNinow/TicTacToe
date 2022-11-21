namespace TicTacToe
{
    partial class TicTacToe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.Retry = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.PlayerTurn = new System.Windows.Forms.Label();
            this.Turn = new System.Windows.Forms.Label();
            this.WinCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 131);
            this.button1.TabIndex = 0;
            this.button1.Tag = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(153, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 131);
            this.button2.TabIndex = 1;
            this.button2.Tag = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(297, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 131);
            this.button3.TabIndex = 2;
            this.button3.Tag = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 212);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 131);
            this.button4.TabIndex = 3;
            this.button4.Tag = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(153, 212);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 131);
            this.button5.TabIndex = 4;
            this.button5.Tag = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(297, 212);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 131);
            this.button6.TabIndex = 5;
            this.button6.Tag = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(9, 342);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(145, 131);
            this.button7.TabIndex = 6;
            this.button7.Tag = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(153, 342);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(145, 131);
            this.button8.TabIndex = 7;
            this.button8.Tag = "7";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(297, 342);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(145, 131);
            this.button9.TabIndex = 8;
            this.button9.Tag = "8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Retry
            // 
            this.Retry.Location = new System.Drawing.Point(298, 482);
            this.Retry.Name = "Retry";
            this.Retry.Size = new System.Drawing.Size(72, 23);
            this.Retry.TabIndex = 9;
            this.Retry.Text = "Retry";
            this.Retry.UseVisualStyleBackColor = true;
            this.Retry.Click += new System.EventHandler(this.Retry_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(369, 482);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(73, 23);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // PlayerTurn
            // 
            this.PlayerTurn.AutoSize = true;
            this.PlayerTurn.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayerTurn.Location = new System.Drawing.Point(9, 9);
            this.PlayerTurn.Name = "PlayerTurn";
            this.PlayerTurn.Size = new System.Drawing.Size(166, 21);
            this.PlayerTurn.TabIndex = 11;
            this.PlayerTurn.Text = "Player turn:X";
            this.PlayerTurn.Click += new System.EventHandler(this.PlayerTurn_Click);
            // 
            // Turn
            // 
            this.Turn.AutoSize = true;
            this.Turn.Font = new System.Drawing.Font("SimSun", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Turn.Location = new System.Drawing.Point(198, 39);
            this.Turn.Name = "Turn";
            this.Turn.Size = new System.Drawing.Size(59, 40);
            this.Turn.TabIndex = 12;
            this.Turn.Text = "00";
            this.Turn.Click += new System.EventHandler(this.label1_Click);
            // 
            // WinCount
            // 
            this.WinCount.AutoSize = true;
            this.WinCount.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WinCount.Location = new System.Drawing.Point(216, 9);
            this.WinCount.Name = "WinCount";
            this.WinCount.Size = new System.Drawing.Size(226, 21);
            this.WinCount.TabIndex = 13;
            this.WinCount.Text = "Win Count: X:0 Y:0";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 511);
            this.Controls.Add(this.WinCount);
            this.Controls.Add(this.Turn);
            this.Controls.Add(this.PlayerTurn);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Retry);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(465, 550);
            this.MinimumSize = new System.Drawing.Size(465, 550);
            this.Name = "TicTacToe";
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button button1;
        public Button button2;
        public Button button3;
        public Button button4;
        public Button button5;
        public Button button6;
        public Button button7;
        public Button button8;
        public Button button9;
        private Button Retry;
        private Button Exit;

        private void PlayerTurn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
namespace TicTacToe
{
    partial class GameMessage
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
            this.label1 = new System.Windows.Forms.Label();
            this.RepositoryAnchor = new System.Windows.Forms.LinkLabel();
            this.RulesAnchor = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "A study Tic-Tac-Toe game project";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RepositoryAnchor
            // 
            this.RepositoryAnchor.AutoSize = true;
            this.RepositoryAnchor.Location = new System.Drawing.Point(71, 39);
            this.RepositoryAnchor.Name = "RepositoryAnchor";
            this.RepositoryAnchor.Size = new System.Drawing.Size(201, 15);
            this.RepositoryAnchor.TabIndex = 1;
            this.RepositoryAnchor.TabStop = true;
            this.RepositoryAnchor.Text = "github.com/GabrielNinow/TicTacToe";
            this.RepositoryAnchor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // RulesAnchor
            // 
            this.RulesAnchor.AutoSize = true;
            this.RulesAnchor.Location = new System.Drawing.Point(72, 64);
            this.RulesAnchor.Name = "RulesAnchor";
            this.RulesAnchor.Size = new System.Drawing.Size(135, 15);
            this.RulesAnchor.TabIndex = 2;
            this.RulesAnchor.TabStop = true;
            this.RulesAnchor.Text = "www.exploratorium.edu";
            this.RulesAnchor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Repository: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rules: ";
            // 
            // GameMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RulesAnchor);
            this.Controls.Add(this.RepositoryAnchor);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(300, 150);
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "GameMessage";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private LinkLabel RepositoryAnchor;
        private LinkLabel RulesAnchor;
        private Label label2;
        private Label label3;
    }
}
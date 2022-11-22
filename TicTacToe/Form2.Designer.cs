namespace TicTacToe
{
    partial class DevelopMessage
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelNome = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelGithub = new System.Windows.Forms.Label();
            this.LabelLinkedin = new System.Windows.Forms.Label();
            this.GithubAnchor = new System.Windows.Forms.LinkLabel();
            this.LinkedinAnchor = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Location = new System.Drawing.Point(12, 15);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(148, 15);
            this.LabelNome.TabIndex = 0;
            this.LabelNome.Text = "Nome:          Gabriel Ninow";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Location = new System.Drawing.Point(12, 36);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(210, 15);
            this.LabelEmail.TabIndex = 1;
            this.LabelEmail.Text = "Email:           Gabrielninow@gmail.com";
            // 
            // LabelGithub
            // 
            this.LabelGithub.AutoSize = true;
            this.LabelGithub.Location = new System.Drawing.Point(12, 57);
            this.LabelGithub.Name = "LabelGithub";
            this.LabelGithub.Size = new System.Drawing.Size(49, 15);
            this.LabelGithub.TabIndex = 2;
            this.LabelGithub.Text = "Github: ";
            // 
            // LabelLinkedin
            // 
            this.LabelLinkedin.AutoSize = true;
            this.LabelLinkedin.Location = new System.Drawing.Point(12, 78);
            this.LabelLinkedin.Name = "LabelLinkedin";
            this.LabelLinkedin.Size = new System.Drawing.Size(58, 15);
            this.LabelLinkedin.TabIndex = 3;
            this.LabelLinkedin.Text = "Linkedin: ";
            // 
            // GithubAnchor
            // 
            this.GithubAnchor.AutoSize = true;
            this.GithubAnchor.Location = new System.Drawing.Point(77, 57);
            this.GithubAnchor.Name = "GithubAnchor";
            this.GithubAnchor.Size = new System.Drawing.Size(151, 15);
            this.GithubAnchor.TabIndex = 4;
            this.GithubAnchor.TabStop = true;
            this.GithubAnchor.Text = "github.com/GabrielNinow/";
            this.GithubAnchor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubAnchor_LinkClicked);
            // 
            // LinkedinAnchor
            // 
            this.LinkedinAnchor.AutoSize = true;
            this.LinkedinAnchor.Location = new System.Drawing.Point(77, 78);
            this.LinkedinAnchor.Name = "LinkedinAnchor";
            this.LinkedinAnchor.Size = new System.Drawing.Size(175, 15);
            this.LinkedinAnchor.TabIndex = 5;
            this.LinkedinAnchor.TabStop = true;
            this.LinkedinAnchor.Text = "linkedin.com/in/gabriel-ninow/";
            this.LinkedinAnchor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkedinAnchor_LinkClicked);
            // 
            // DevelopMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.LinkedinAnchor);
            this.Controls.Add(this.GithubAnchor);
            this.Controls.Add(this.LabelLinkedin);
            this.Controls.Add(this.LabelGithub);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.LabelNome);
            this.MaximumSize = new System.Drawing.Size(300, 150);
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "DevelopMessage";
            this.Text = "About Developer";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelNome;
        private Label LabelEmail;
        private Label LabelGithub;
        private Label LabelLinkedin;
        private LinkLabel GithubAnchor;
        private LinkLabel LinkedinAnchor;
    }
}
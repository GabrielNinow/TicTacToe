using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TicTacToe
{
    public partial class DevelopMessage : Form
    {
        public DevelopMessage()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void LinkedinAnchor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "www.linkedin.com/in/gabriel-ninow/";
            if (e.Link.LinkData != null)
                url = e.Link.LinkData.ToString();
            else
                url = LinkedinAnchor.Text.Substring(e.Link.Start, e.Link.Length);

            if (!url.Contains("://"))
                url = "https://" + url;

            var si = new ProcessStartInfo(url);
            si.UseShellExecute = true;
            Process.Start(si);
            LinkedinAnchor.LinkVisited = true;
        }

        private void GithubAnchor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "github.com/GabrielNinow/";
            if (e.Link.LinkData != null)
                url = e.Link.LinkData.ToString();
            else
                url = GithubAnchor.Text.Substring(e.Link.Start, e.Link.Length);

            if (!url.Contains("://"))
                url = "https://" + url;

            var si = new ProcessStartInfo(url);
            si.UseShellExecute = true;
            Process.Start(si);
            GithubAnchor.LinkVisited = true;

        }
    }
}

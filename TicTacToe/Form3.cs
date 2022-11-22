using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class GameMessage : Form
    {
        public GameMessage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void GameMessage_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/GabrielNinow/TicTacToe";
            if (e.Link.LinkData != null)
                url = e.Link.LinkData.ToString();
            else
                url = RepositoryAnchor.Text.Substring(e.Link.Start, e.Link.Length);

            if (!url.Contains("://"))
                url = "https://" + url;

            var si = new ProcessStartInfo(url);
            si.UseShellExecute = true;
            Process.Start(si);
            RepositoryAnchor.LinkVisited = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.exploratorium.edu/brain_explorer/tictactoe.html";

            if (!url.Contains("://"))
                url = "https://" + url;

            var si = new ProcessStartInfo(url);
            si.UseShellExecute = true;
            Process.Start(si);
            RulesAnchor.LinkVisited = true;
        }
    }
}

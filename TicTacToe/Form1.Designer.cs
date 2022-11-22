using System.Diagnostics;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        private int XVictoryCount = 0;
        private int OVictoryCount = 0;
        private int TurnCount = 0;
        private string Currentplayer = "X";
        private bool GameOver = false;
        string[] buttonsChecked = new string[9];
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonClick(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonClick(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonClick(button3);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonClick(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonClick(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonClick(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonClick(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonClick(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonClick(button9);
        }

        private void Retry_Click(object sender, EventArgs e)
        {
            ClearTable();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        public Button ButtonClick(Button button)
        {
            if (button.Text == "")
            {
                TurnCount++;
                button.Text = Currentplayer;
                buttonsChecked[Int16.Parse(button.Tag.ToString())] = Currentplayer;

                EndTurn();

                if (Currentplayer == "X" && GameOver == false)
                {
                    Currentplayer = "O";
                }
                else
                {
                    Currentplayer = "X";
                }

                PlayerTurn.Text = "Player turn: "+Currentplayer;
                Turn.Text = TurnCount.ToString().PadLeft(2,'0');

            }
            return button;
        }

        public void EndTurn()
        {
            if (buttonsChecked[0] == Currentplayer && buttonsChecked[1] == Currentplayer && buttonsChecked[2] == Currentplayer ||
                buttonsChecked[3] == Currentplayer && buttonsChecked[4] == Currentplayer && buttonsChecked[5] == Currentplayer ||
                buttonsChecked[6] == Currentplayer && buttonsChecked[7] == Currentplayer && buttonsChecked[8] == Currentplayer ||
                buttonsChecked[0] == Currentplayer && buttonsChecked[3] == Currentplayer && buttonsChecked[6] == Currentplayer ||
                buttonsChecked[1] == Currentplayer && buttonsChecked[4] == Currentplayer && buttonsChecked[7] == Currentplayer ||
                buttonsChecked[2] == Currentplayer && buttonsChecked[5] == Currentplayer && buttonsChecked[8] == Currentplayer ||
                buttonsChecked[0] == Currentplayer && buttonsChecked[4] == Currentplayer && buttonsChecked[8] == Currentplayer ||
                buttonsChecked[2] == Currentplayer && buttonsChecked[4] == Currentplayer && buttonsChecked[6] == Currentplayer)
            {
                GameOver = true;
            }
            else
            {
                GameOver = false;
            }

            if (GameOver)
            {
                DialogResult dialogResult = MessageBox.Show("Player " + Currentplayer + " won! \nDo you want to play again?", "Congratulations!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                
                if (Currentplayer == "X")
                {
                    XVictoryCount++;
                }
                else
                {
                    OVictoryCount++;
                }

                WinCount.Text = $"Win Count: X:{XVictoryCount} Y:{OVictoryCount}";

                if (dialogResult == DialogResult.Yes)
                {
                    ClearTable();
                }
                else
                {
                    Application.Exit();
                }
            }

            bool HasEmptyTile = false;

            for(int i = 1; i < buttonsChecked.Length; i++)
            {
                if (buttonsChecked[i] == null)
                {
                    HasEmptyTile = true;
                    break;
                }
            }

            if (!HasEmptyTile)
            {
                DialogResult dialogResult = MessageBox.Show("Seens like the game is tied! \nDo you want to play again?", "Oh no!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    GameOver = true;
                    ClearTable();  
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        public void ClearTable()
        {
            Array.Clear(buttonsChecked, 0, buttonsChecked.Length);
            Currentplayer = "X";
            PlayerTurn.Text = "Player turn: " + Currentplayer;
            TurnCount = 0;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            Turn.Text = "00";
        }

        private Label PlayerTurn;
        private Label Turn;
        private Label WinCount;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem developerToolStripMenuItem;
        private ToolStripMenuItem gameToolStripMenuItem;
    }
}
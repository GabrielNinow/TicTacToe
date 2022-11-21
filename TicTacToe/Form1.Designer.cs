namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        private string Currentplayer = "X";
        private bool Victory = false;
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
                button.Text = Currentplayer;
                buttonsChecked[Int16.Parse(button.Tag.ToString())] = Currentplayer;

                EndTurn();

                if (Currentplayer == "X")
                {
                    Currentplayer = "O";
                }
                else
                {
                    Currentplayer = "X";
                }
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
                Victory = true;
            }

            if (Victory)
            {
                DialogResult dialogResult = MessageBox.Show("Player " + Currentplayer + " won! \nDo you want to play again?", "Congratulations!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
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
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            Array.Clear(buttonsChecked, 0, buttonsChecked.Length);
            Currentplayer = "X";
            Victory = false;
        }
    }
}
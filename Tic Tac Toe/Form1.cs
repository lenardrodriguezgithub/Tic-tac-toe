namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // variables
        public short count;
        public short xcount=0, ocount=0;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            MenuPanel.Hide();
            PlayPanel.Show();
        }
        
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void BackButton_Click(object sender, EventArgs e)
        {
            PlayPanel.Hide();
            MenuPanel.Show();
            ClearButtons(sender, e);
        }

        // mark button and show whose turn
        private void PlayerTurn(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Text = count++ % 2 == 0 ? "x" : "o";
            btn.Enabled = false;
            if (count >= 1)
            {
                if (count % 2 == 1)
                {
                    showturn.Text = "o";
                }
                else
                {
                    showturn.Text = "x";
                }
            }

            CheckWinner(sender, e);
        }

        //check the winner
        private void CheckWinner(object sender, EventArgs e)
        {
            // winner is x
            if
            (//horizontal
                button1.Text == "x" && button2.Text == "x" && button3.Text == "x" ||
                button4.Text == "x" && button5.Text == "x" && button6.Text == "x" ||
                button7.Text == "x" && button8.Text == "x" && button9.Text == "x" ||
                //vertical
                button1.Text == "x" && button4.Text == "x" && button7.Text == "x" ||
                button2.Text == "x" && button5.Text == "x" && button8.Text == "x" ||
                button3.Text == "x" && button6.Text == "x" && button9.Text == "x" ||
                //diagonal
                button1.Text == "x" && button5.Text == "x" && button9.Text == "x" ||
                button3.Text == "x" && button5.Text == "x" && button7.Text == "x"
            )
            {
                MessageBox.Show("X WINNER!");
                ClearButtons(sender, e);
                xcount++;
                // update score
                xscore.Text = xcount.ToString();
            }
            // winner is o
            else if
            (//horizontal
                button1.Text == "o" && button2.Text == "o" && button3.Text == "o" ||
                button4.Text == "o" && button5.Text == "o" && button6.Text == "o" ||
                button7.Text == "o" && button8.Text == "o" && button9.Text == "o" ||
                //vertical
                button1.Text == "o" && button4.Text == "o" && button7.Text == "o" ||
                button2.Text == "o" && button5.Text == "o" && button8.Text == "o" ||
                button3.Text == "o" && button6.Text == "o" && button9.Text == "o" ||
                //diagonal
                button1.Text == "o" && button5.Text == "o" && button9.Text == "o" ||
                button3.Text == "o" && button5.Text == "o" && button7.Text == "o"
            )
            {
                MessageBox.Show("O WINNER!");
                ClearButtons(sender, e);
                ocount++;
                // update score
                oscore.Text = ocount.ToString();
            }
            // draw game
            else if
                (count >= 9)
            {
                MessageBox.Show("XO DRAW!");
                ClearButtons(sender, e);

            }
        }

        //clear buttons and clear turntext
        private void ClearButtons(object sender, EventArgs e)
        {
            //enable button
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            //cleartext
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
            
            //reset count
            count = 0;
            xcount = 0;
            ocount = 0;

            //update score
            xscore.Text = "0";
            oscore.Text = "0";

            // reset turn
            showturn.Text = " ";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            PlayerTurn(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlayerTurn(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlayerTurn(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlayerTurn(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PlayerTurn(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PlayerTurn(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PlayerTurn(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PlayerTurn(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PlayerTurn(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void xscore_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ClearButtons(sender, e);
        }

    }
}
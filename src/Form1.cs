namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private int xScore = 0;
        private int oScore = 0;
        private int attempt = 0;//attempt decide player
        private bool playerWin = false;
        private bool help = false;
        private bool checkTie = false;
        private void press(Button temp)
        {
            attempt++;
            temp.Enabled = false;
            tie();
            if (attempt % 2 == 0 && !playerWin)
            {
                temp.Text = "O";
                label2.Text = "X";
            }
            else
            {
                temp.Text = "X";
                label2.Text = "O";
            }
            if (checkTie)
            {
                label1.Text = "Tie";
                label2.Visible = false;
                checkTie = false;
            }
            label7.Focus();
        }
        private void win(Button temp1, Button temp2, Button temp3)
        {
            playerWin = true;
            gameButtonDisable();
            temp1.BackColor = SystemColors.ControlDark;
            temp2.BackColor = SystemColors.ControlDark;
            temp3.BackColor = SystemColors.ControlDark;
            label1.Text = "Win";
            label2.Visible = true;
            if (temp1.Text == "O")
            {
                oScore++;
                label6.Text = oScore + "";
                label2.Text = "O";
            }
            else
            {
                xScore++;
                label5.Text = xScore + "";
                label2.Text = "X";
            }
        }
        private void tie()
        {
            if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false)
            {
                if (button4.Enabled == false && button5.Enabled == false && button6.Enabled == false)
                {
                    if (button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
                    {
                        checkTie = true;
                    }
                }
            }
        }
        private void match(Button temp)
        {
            if (attempt >= 5 && temp.Text == "O")
            {
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    win(button1, button2, button3);
                }
                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    win(button4, button5, button6);
                }
                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    win(button7, button8, button9);
                }
                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    win(button1, button4, button7);
                }
                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    win(button2, button5, button8);
                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    win(button3, button6, button9);
                }
                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    win(button1, button5, button9);
                }
                else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
                {
                    win(button3, button5, button7);
                }
            }
            else if (attempt >= 5 && temp.Text == "X")
            {
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    win(button1, button2, button3);
                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    win(button4, button5, button6);
                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    win(button7, button8, button9);
                }
                else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    win(button1, button4, button7);
                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    win(button2, button5, button8);
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    win(button3, button6, button9);
                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    win(button1, button5, button9);
                }
                else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                {
                    win(button3, button5, button7);
                }
            }
        }
        private void gameButtonEnable()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }
        private void gameButtonDisable()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        private void gameButtonDefault()
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
        }
        private void gameButtonDefaultBackColor()
        {
            button1.BackColor = SystemColors.Menu;
            button2.BackColor = SystemColors.Menu;
            button3.BackColor = SystemColors.Menu;
            button4.BackColor = SystemColors.Menu;
            button5.BackColor = SystemColors.Menu;
            button6.BackColor = SystemColors.Menu;
            button7.BackColor = SystemColors.Menu;
            button8.BackColor = SystemColors.Menu;
            button9.BackColor = SystemColors.Menu;
        }
        private void hideGameScreen()
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
        }
        private void showGameScreen()
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
        }
        private void hideMenuScreen()
        {
            label8.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
        }
        private void showMenuScreen()
        {
            label8.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
        }
        private void hideHelpScreen()
        {
            textBox1.Visible = false;
            if (!help)
            {
                label7.Visible = false;
                button12.Visible = false;
            }
        }
        private void showHelpScreen()
        {
            label7.Visible = true;
            textBox1.Visible = true;
            button12.Visible = true;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            hideGameScreen();
            hideHelpScreen();
            gameButtonDefault();
            gameButtonDefaultBackColor();
            label7.Focus();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            press(button1);
            match(button1);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            press(button2);
            match(button2);
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            press(button3);
            match(button3);
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            press(button4);
            match(button4);
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            press(button5);
            match(button5);
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            press(button6);
            match(button6);
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            press(button7);
            match(button7);
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            press(button8);
            match(button8);
        }
        private void button9_Click_1(object sender, EventArgs e)
        {
            press(button9);
            match(button9);
        }
        private void button10_Click(object sender, EventArgs e)//game screen clear
        {
            label1.Text = "Turn";
            label2.Visible = true;
            gameButtonDefault();
            gameButtonEnable();
            gameButtonDefaultBackColor();
            label7.Focus();
            if (attempt % 2 == 0 && playerWin)//O win
            {
                attempt = 1;
                label2.Text = "O";
                playerWin = false;
            }
            else if (attempt % 2 != 0 && playerWin)//X win
            {
                attempt = 0;
                label2.Text = "X";
                playerWin = false;
            }
        }
        private void button11_Click(object sender, EventArgs e)//game screen help
        {
            hideGameScreen();
            showHelpScreen();
            label7.Focus();
            this.Text = "Tic Tac Toe - Help";
            help = true;
        }
        private void button13_Click(object sender, EventArgs e)//game screen new
        {
            gameButtonDefault();
            gameButtonEnable();
            gameButtonDefaultBackColor();
            label7.Focus();
            attempt = 0;
            xScore = 0;
            oScore = 0;
            playerWin = false;
            label5.Text = "0";
            label6.Text = "0";
            label2.Visible = true;
            label2.Text = "X";
            label1.Text = "Turn";
        }
        private void button12_Click(object sender, EventArgs e)//game and menu screen back
        {
            label7.Focus();
            if (help) //on game screen
            {
                hideMenuScreen();
                hideHelpScreen();
                showGameScreen();
                this.Text = "Tic Tac Toe";
                help = false;
            }
            else //on menu screen
            {
                hideGameScreen();
                hideHelpScreen();
                showMenuScreen();
            }
        }
        private void button14_Click(object sender, EventArgs e)//menu screen play
        {
            hideMenuScreen();
            showGameScreen();
            label7.Focus();
            this.Text = "Tic Tac Toe - Play";
        }
        private void button15_Click_1(object sender, EventArgs e)//menu screen help
        {
            hideMenuScreen();
            showHelpScreen();
            this.Text = "Tic Tac Toe - Help";
        }
        private void button16_Click(object sender, EventArgs e)//menu screen exit
        {
            Close();
        }
        // programmer information...
        // program by -> Vaibhav Kheriwal
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            this.Text = "";

            this.Height = 300;
            this.Width = 245;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.CenterToScreen(); ;

            button11.Size = new Size(25, 25);
            button11.Location = new Point(this.Width - button11.Width - 7, 0);

            button1.Size = new Size(75, 75);
            button2.Size = new Size(75, 75);
            button3.Size = new Size(75, 75);
            button4.Size = new Size(75, 75);
            button5.Size = new Size(75, 75);
            button6.Size = new Size(75, 75);
            button7.Size = new Size(75, 75);
            button8.Size = new Size(75, 75);
            button9.Size = new Size(75, 75);

            button9.Location = new Point(this.Width - 5 - button9.Width - 3, this.Height - 5 - button9.Height);
            button8.Location = new Point(this.Width - 5 - button9.Width * 2 - 5 - 3, this.Height - 5 - button9.Height);
            button7.Location = new Point(this.Width - 5 - button9.Width * 3 - 10 - 3, this.Height - 5 - button9.Height);
            button6.Location = new Point(this.Width - 5 - button9.Width - 3, this.Height - 5 - button9.Height * 2 - 5);
            button5.Location = new Point(this.Width - 5 - button9.Width * 2 - 5 - 3, this.Height - 5 - button9.Height * 2 - 5);
            button4.Location = new Point(this.Width - 5 - button9.Width * 3 - 10 - 3, this.Height - 5 - button9.Height * 2 - 5);
            button3.Location = new Point(this.Width - 5 - button9.Width - 3, this.Height - 5 - button9.Height * 3 - 5 - 5);
            button2.Location = new Point(this.Width - 5 - button9.Width * 2 - 5 - 3, this.Height - 5 - button9.Height * 3 - 5 - 5);
            button1.Location = new Point(this.Width - 5 - button9.Width * 3 - 10 - 3, this.Height - 5 - button9.Height * 3 - 5 - 5);

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button10.Size = new Size(75, 30);
            button10.Location = new Point(button2.Location.X, button2.Location.Y - 30 - 5);

            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button11.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
        }

        bool nicha = false;
        bool winner = false;
        int schet = 0;
        string text;

        Form2 form2 = new Form2();

        private void win()
        {
            if(button1.Text=="x" && button2.Text=="x" && button3.Text== "x")
            {
                winner = true;
                text = "x";
            }
            if (button1.Text == "o" && button2.Text == "o" && button3.Text == "o")
            {
                winner = true;
                text = "o";
            }
            if (button4.Text == "o" && button5.Text == "o" && button6.Text == "o")
            {
                winner = true;
                text = "o";
            }
            if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
            {
                winner = true;
                text = "x";
            }
            if (button7.Text == "x" && button8.Text == "x" && button9.Text == "x")
            {
                winner = true;
                text = "x";
            }
            if (button7.Text == "o" && button8.Text == "o" && button9.Text == "o")
            {
                winner = true;
                text = "o";
            }
            if (button1.Text == "x" && button4.Text == "x" && button7.Text == "x")
            {
                winner = true;
                text = "x";
            }
            if (button1.Text == "o" && button4.Text == "o" && button7.Text == "o")
            {
                winner = true;
                text = "o";
            }
            if (button2.Text == "x" && button5.Text == "x" && button8.Text == "x")
            {
                winner = true;
                text = "x";
            }
            if (button2.Text == "o" && button8.Text == "o" && button5.Text == "o")
            {
                winner = true;
                text = "o";
            }
            if (button3.Text == "x" && button6.Text == "x" && button9.Text == "x")
            {
                winner = true;
                text = "x";
            }
            if (button3.Text == "o" && button6.Text == "o" && button9.Text == "o")
            {
                winner = true;
                text = "o";
            }
            if (button1.Text == "x" && button5.Text == "x" && button9.Text == "x")
            {
                winner = true;
                text = "x";
            }
            if (button1.Text == "o" && button5.Text == "o" && button9.Text == "o")
            {
                winner = true;
                text = "o";
            }
            if (button3.Text == "x" && button5.Text == "x" && button7.Text == "x")
            {
                winner = true;
                text = "x";
            }
            if (button7.Text == "o" && button5.Text == "o" && button3.Text == "o")
            {
                winner = true;
                text = "o";
            }

        }

        private void losewin()
        {
            if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
                nicha = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            schet = 0;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            winner = false;
            nicha = false;
            text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            if (schet % 2 == 0)
                button1.Text = "x";
            else
                button1.Text = "o";

            win();
            losewin();

            if (winner)
            {
                form2.Show();
                form2.label1.Text = text + " " + "WIN";

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

            else if(nicha)
            {
                form2.Show();
                form2.label1.Text = "DRAW";
            }

            schet++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;

            if (schet % 2 == 0)
                button2.Text = "x";
            else
                button2.Text = "o";

            win();
            losewin();

            if (winner)
            {
                form2.Show();
                form2.label1.Text = text + " " + "WIN";

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

            else if (nicha)
            {
                form2.Show();
                form2.label1.Text = "DRAW";
            }

            schet++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;

            if (schet % 2 == 0)
                button3.Text = "x";
            else
                button3.Text = "o";

            win();
            losewin();

            if (winner)
            {
                form2.Show();
                form2.label1.Text = text + " " + "WIN";

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

            else if (nicha)
            {
                form2.Show();
                form2.label1.Text = "DRAW";
            }

            schet++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;

            if (schet % 2 == 0)
                button4.Text = "x";
            else
                button4.Text = "o";

            win();
            losewin();

            if (winner)
            {
                form2.Show();
                form2.label1.Text = text + " " + "WIN";

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

            else if (nicha)
            {
                form2.Show();
                form2.label1.Text = "DRAW";
            }

            schet++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;

            if (schet % 2 == 0)
                button5.Text = "x";
            else
                button5.Text = "o";

            win();
            losewin();

            if (winner)
            {
                form2.Show();
                form2.label1.Text = text + " " + "WIN";

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

            else if (nicha)
            {
                form2.Show();
                form2.label1.Text = "DRAW";
            }

            schet++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;

            if (schet % 2 == 0)
                button6.Text = "x";
            else
                button6.Text = "o";

            win();
            losewin();

            if (winner)
            {
                form2.Show();
                form2.label1.Text = text + " " + "WIN";

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

            else if (nicha)
            {
                form2.Show();
                form2.label1.Text = "DRAW";
            }

            schet++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;

            if (schet % 2 == 0)
                button7.Text = "x";
            else
                button7.Text = "o";

            win();
            losewin();

            if (winner)
            {
                form2.Show();
                form2.label1.Text = text + " " + "WIN";

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

            else if (nicha)
            {
                form2.Show();
                form2.label1.Text = "DRAW";
            }

            schet++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;

            if (schet % 2 == 0)
                button8.Text = "x";
            else
                button8.Text = "o";

            win();
            losewin();

            if (winner)
            {
                form2.Show();
                form2.label1.Text = text + " " + "WIN";

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

            else if (nicha)
            {
                form2.Show();
                form2.label1.Text = "DRAW";
            }

            schet++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;

            if (schet % 2 == 0)
                button9.Text = "x";
            else
                button9.Text = "o";

            win();
            losewin();

            if (winner)
            {
                form2.Show();
                form2.label1.Text = text + " " + "WIN";

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

            else if (nicha)
            {
                form2.Show();
                form2.label1.Text = "DRAW";
            }

            schet++;
        }
    }
}

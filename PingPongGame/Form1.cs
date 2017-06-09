using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PingPongGame
{
  
    public partial class Form1 : Form
    {
        bool goRight;
        bool goLeft;
        int speed = 10;

        int ballx = 5;
        int bally = 5;

        int score = 0;
        int timeLeft;
        int life;
        int timeToSHow;

        private Random rnd = new Random();

        public Form1(int timeLeft, int speed, int tableWidth, int life, int ballW, int ballH)
        {
            InitializeComponent();
            this.timeLeft = timeLeft;
            this.life = life;
            ball1.Width = ballW;
            ball1.Height = ballH;
            timer1.Interval = speed;
            player.Width = tableWidth;
            bonus.Hide();
            gg.Hide();
            go.Hide();
            label3.Text = timeLeft + " seconds";
            lifes.Text = "Life left: " + life;
            String[] colour = Enum.GetNames(typeof(colours));
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "block")
                {

                    String randomEnum = colour[rnd.Next(colour.Length)];
                    Color randomColor = Color.FromName(randomEnum);
                    x.BackColor = randomColor;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && player.Left > 0)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && player.Left + player.Width < 920)
            {
                goRight = true;
            }
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if(e.KeyCode == Keys.Enter)
            {
                Form2 form = new Form2();
                form.Show();
                this.Close();
               
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ball1.Left += ballx;
            ball1.Top += bally;
            label2.Text = "Score: " + score;

            if (goLeft)
            {
                player.Left -= speed;
            }
            if (goRight)
            {
                player.Left += speed;
            }
            if (player.Left < 1)
            {
                goLeft = false;
            }
            if (player.Left + player.Width > 920)
            {
                goRight = false;
            }
            if (ball1.Left + ball1.Width > ClientSize.Width || ball1.Left < 0)
            {
                ballx = -ballx;
            }
            if (ball1.Top < 0 || ball1.Bounds.IntersectsWith(player.Bounds))
            {
                bally = -bally;
            }
            if (ball1.Top + ball1.Height > ClientSize.Height)
            {
                life--;
                lifes.Text = "Life left: " + life;
                if(life == 0)
                {
                    gameOver("Game Over!");
                }
                else
                {
                    ball1.Top = 412;
                    ball1.Left = 84;
                }
            }
            String[] colour = Enum.GetNames(typeof(colours));
            String getColorOne = colour[0];
            Color getPlusOne = Color.FromName(getColorOne);
            String getColorTwo = colour[4];
            Color getPlusTwo = Color.FromName(getColorTwo);
            String getColorThree = colour[10];
            Color getPlusThree = Color.FromName(getColorThree);

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "block")
                {
                    if (ball1.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        bally = -bally;
                        score++;
                        if (x.BackColor == getPlusOne)
                        {
                            timeLeft += 1;
                            bonus.Text = "+ 1 sec";
                            bonus.Show();
                            timeToSHow = 2;
                            timer3.Start();

                        }
                        if (x.BackColor == getPlusTwo)
                        {
                            timeLeft += 2;
                            bonus.Text = "+ 2 sec";
                            bonus.Show();
                            timeToSHow = 2;
                            timer3.Start();

                        }
                        if (x.BackColor == getPlusThree)
                        {
                            timeLeft += 3;
                            bonus.Text = "+ 3 sec";
                            bonus.Show();
                            timeToSHow = 2;
                            timer3.Start();

                        }
                    }
                }
            }
            if (score > 34)
            {
                gameOver("You won!!!");
              
            }
        }
        private void gameOver(String message)
        {
            go.Text = message;
            finalscore.Text = "Your score: " + score;
            go.Show();
            finalscore.Show();
            timer1.Stop();
            timer2.Stop();
            
        }

        private void keyispressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                if (go.Visible == false)
                {
                    if (timer1.Enabled == true)
                    {
                        gg.Text = "Paused";
                        gg.Show();
                        timer1.Stop();
                        timer2.Stop();
                    }
                    else
                    {
                        gg.Hide();
                        timer1.Start();
                        timer2.Start();
                    }
                }
               

            }
            
        }
    
        public enum colours
        {
            DeepPink, DarkKhaki, Lavender, Gold, LimeGreen, Wheat, Orange, OrangeRed, SkyBlue, WhiteSmoke, Blue, 
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                label3.Text = timeLeft + " seconds";
            }
            if (timeLeft == 0)
            {
                gameOver("Game Over!");
            }
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            if (timeToSHow > 0)
            {
                timeToSHow--;
            }
            if (timeToSHow == 0)
            {
                bonus.Hide();
            }
            
        }

    }
}

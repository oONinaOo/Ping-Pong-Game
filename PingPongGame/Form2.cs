using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongGame
{
    public partial class Form2 : Form
    {
        int getTime;
        int getSpeed;
        int getWidth;
        int getLifes;
        int getBallW;
        int getBallH;
        public Form2()
        {
        
            InitializeComponent();
            label4.Hide();
            easy.Hide();
            normal.Hide();
            hardcore.Hide();
            controls.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progress.Width += 5;
            if (progress.Width >= 421)
            {
                timer1.Stop();
                progress.Hide();
                progressfull.Hide();
                label3.Hide();
                label4.Show();
                easy.Show();
                normal.Show();
                hardcore.Show();
                controls.Show();

            }
        }
        public int changeTime
        {
            get { return getTime; }
            set { getTime = value; }
        }
        public int changeSpeed
        {
            get { return getSpeed; }
            set { getSpeed = value; }
        }
        public int changeWidth
        {
            get { return getWidth;  }
            set { getWidth = value; }
        }
        public int changeLifes
        {
            get { return getLifes; }
            set { getLifes = value; }
        }
         public int changeBallW
        {
            get { return getBallW; }
            set { getBallW = value; }
        }
        public int changeBallH
        {
            get { return getBallH; }
            set { getBallH = value; }
        }



        private void easy_Click(object sender, EventArgs e)
        {
            changeTime = 90;
            changeSpeed = 30;
            changeWidth = 250;
            changeLifes = 2;
            changeBallW = 23;
            changeBallH = 23;
            Form1 form = new Form1(changeTime, changeSpeed, changeWidth, changeLifes, changeBallW, changeBallH);
            form.Show();
            this.Hide();
        }

        private void normal_Click(object sender, EventArgs e)
        {
            changeTime = 60;
            changeSpeed = 20;
            changeWidth = 180;
            changeLifes = 2;
            changeBallW = 23;
            changeBallH = 23;
            Form1 form = new Form1(changeTime, changeSpeed, changeWidth, changeLifes, changeBallW, changeBallH);
            form.Show();
            this.Hide();
        }

        private void hardcore_Click(object sender, EventArgs e)
        {
            changeTime = 25;
            changeSpeed = 10;
            changeWidth = 120;
            changeLifes = 1;
            changeBallW = 19;
            changeBallH = 19;
            Form1 form = new Form1(changeTime, changeSpeed, changeWidth, changeLifes, changeBallW, changeBallH);
            form.Show();
            this.Hide();
        }

        private void controls_Click(object sender, EventArgs e)
        {
            Form3 controlsList = new Form3();
            controlsList.Show();
        }
    }
}

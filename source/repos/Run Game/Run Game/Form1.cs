using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Run_Game
{
    public partial class Form1 : Form
    {
        const int PLAYERUP = 328;
        const int PLAYERDOWN = 30;
        int gravity;
        int gravityValue = 8;
        int obstacleSpeed = 15;
        int score = 0;
        int hightScore = 0;
        bool gameOver = false;
        Random random = new Random();


        public Form1 ()
        {
            InitializeComponent();
            RestartGame();
        }

        private void Lbl_Score_Click (object sender, EventArgs e)
        {

        }

        private void GameTimerEvent (object sender, EventArgs e)
        {
            lbl_Score.Text = "Score: " + score;
            lbl_HightScore.Text = "Hight Score: " + hightScore;
            Player.Top += gravity;

            if (Player.Top > PLAYERDOWN)
            {
                gravity = 0;
                Player.Top = 328;
                Player.Image = Properties.Resources.run_down0;
            }
            else if (Player.Top < PLAYERUP)
            {
                gravity = 0;
                Player.Top = 30;
                Player.Image = Properties.Resources.run_up0;
            }

            foreach (Control item in this.Controls)
            {
                if (item is PictureBox && (string)item.Tag == "Obstacle")
                {
                    item.Left -= obstacleSpeed;

                    if (item.Left < -100)
                    {
                        item.Left = random.Next(1200, 3000);
                        score += 1;

                    }

                    if (item.Bounds.IntersectsWith(Player.Bounds))
                    {
                        GameTimer.Stop();
                        lbl_Score.Text = " Game Over!!\n Press Enter to Restart. ";
                        gameOver = true;

                        if (score > hightScore)
                            hightScore = score;

                    }

                }

            }

        }

        private void KeyIsUp (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (Player.Top == 328)
                {
                    Player.Top -= 10;
                    gravity = -gravityValue;
                }
                else if (Player.Top == 30)
                {
                    Player.Top += 10;
                    gravity = gravityValue;
                }
            }
            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }

        private void RestartGame ()
        {
            lbl_Score.Parent = pictureBox1;
            lbl_HightScore.Parent = pictureBox2;
            lbl_HightScore.Top = 0;
            Player.Location = new Point(156, 271);
            Player.Image = Properties.Resources.run_down0;
            score = 0;
            gravityValue = 8;
            gravity = gravityValue;
            obstacleSpeed = 15;

            foreach (Control item in this.Controls)
            {
                if (item is PictureBox && (string)item.Tag == "Obstacle")
                {
                    item.Left = random.Next(1200, 3000);
                }

            }

            GameTimer.Start();

        }

        private void Form1_Load (object sender, EventArgs e)
        {

        }
    }
}

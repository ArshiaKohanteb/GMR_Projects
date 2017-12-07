using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {                                              
        Graphics gfx;
        Bitmap map;
        int ballx = 894;
        int bally = 450;
        int ballspeedx = 5;
        int ballspeedy = 2;
        int ponglx = 0;
        int pongly = 30;
        int pongrx = 1869;
        int pongry = 32;
        int time = 0;
        int timercount = 500;
        int click1;
        int player1;
        int player2;

        Rectangle left;
        Rectangle right;
        Rectangle ball;

        bool isDown = false;
        bool isUp = false;
        bool isW = false;
        bool isS = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            map = new Bitmap(ClientSize.Width, ClientSize.Height);
            gfx = Graphics.FromImage(map);

            left = new Rectangle(ponglx, pongly, 50, 200);
            right = new Rectangle(pongrx, pongry, 50, 200);
            ball = new Rectangle(ballx, bally, 37, 37);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Visible = false;
            this.Focus();

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Coordinates.Text = string.Format("X: {0}, Y: {1}", e.X, e.Y);
        }
                private void timer1_Tick(object sender, EventArgs e)
        {
            gfx.Clear(BackColor);
            //erase
            if (ballx > ClientSize.Width - 37)
            {
                player1++;
            }
            if (ballx < 0)
            {
                player2++;
            }
            if (ballx > ClientSize.Width - 37 || ballx < 0)
            {
                timer1.Enabled = false;
                ballx = 894;
                bally = 450;
                ballspeedx = 5;
                ballspeedy = 2;
                timercount = 500;
                click1++;
                timer1.Enabled = true;
            }
            label4.Text = String.Format("Player 1: {0}",player1);
            label5.Text = String.Format("Player 2: {0}", player2);
            timercount--;
            label1.Text = timercount.ToString();
            ballx += ballspeedx;
            bally += ballspeedy;
            if (ballx > ClientSize.Width + 63)
            {
                ballspeedx *= -1;
            }

            if (ballx < -100)
            {
                ballspeedx *= -1;
            }

            if (bally > ClientSize.Height - 37)
            {
                ballspeedy *= -1;
            }

            if (bally < 0)
            {
                ballspeedy *= -1;
            }

            if (isUp == true && pongry > 0)
            {
                pongry -= 20;
            }
            if (isDown == true && pongry + 200 < ClientSize.Height)
            {
                pongry += 20;
            }
            if (isW == true && pongly > 0)
            {
                pongly -= 20;
            }
            if (isS == true && pongly + 200 < ClientSize.Height)
            {
                pongly += 20;
            }
            if (player1 == 10)
            {
                timer1.Enabled = false;
                MessageBox.Show("!!!!!!Player One Won!!!!!!");
            }
            if (player2 == 10)
            {
                timer1.Enabled = false;
                MessageBox.Show("!!!!!!Player Two Won!!!!!!");
            }
            right.X = pongrx;
            right.Y = pongry;
            left.X = ponglx;
            left.Y = pongly;

            ball.X = ballx;
            ball.Y = bally;

            if (ball.IntersectsWith(left))
            {
                ballspeedx--;
                ballspeedx *= -1;

                if (ballspeedy > 0)
                {
                    ballspeedy++;
                }
                else
                {
                    ballspeedy--;
                }
            }

            if (ball.IntersectsWith(right))
            {
                ballspeedx++;
                ballspeedx *= -1;

                if (ballspeedy > 0)
                {
                    ballspeedy++;
                }
                else
                {
                    ballspeedy--;
                    ballspeedy++;
                }

            }



            gfx.FillEllipse(Brushes.MediumSpringGreen, ponglx, pongly, 50, 200); //draw left
            gfx.FillEllipse(Brushes.MediumSpringGreen, pongrx, pongry, 50, 200); //draw right
            gfx.FillEllipse(Brushes.Gold, ballx, bally, 37, 37); //draw ball

            //gfx.DrawRectangle(Pens.Gold, ball); //ball hitbox
            //gfx.DrawRectangle(Pens.Red, left); //left hitbox
            //gfx.DrawRectangle(Pens.Black, right); //right hitbox

            time++;
            


            bitBox.Image = map;
            //if (pongly < 0)

        }
                                                    //Next Class: && keycode
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                isUp = true;
                
            }
            if (e.KeyCode == Keys.Down)
            {
                isDown = true;
                
            }
            if (e.KeyCode == Keys.W)
            {
                isW = true;
                
            }
            if (e.KeyCode == Keys.S)
            {
                isS = true;
                
            }

            if (e.KeyCode == Keys.X)
            {
                ballspeedx *= 2;
            }

            if (e.KeyCode == Keys.Z && ballspeedx > 1)
            {
                ballspeedx /= 2;
            }
            
        }
        

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                isUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                isDown = false;
            }
            if (e.KeyCode == Keys.W)
            {
                isW = false;
            }
            if (e.KeyCode == Keys.S)
            {
                isS = false;
            }
            
        }

        private void bitBox_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            timercount = 500;
            timer1.Enabled = true;
            ballx = 894;
            bally = 450;
            click1++;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("You Played The Game {0} Times",click1));
        }
    }
}

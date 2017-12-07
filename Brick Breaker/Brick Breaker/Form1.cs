using System;                                                                                                
using System.Collections.Generic;                                                                            
using System.ComponentModel;                                                                                 
using System.Data;                                                                                           
using System.Drawing;                                                                                        
using System.Linq;                                                                                           
using System.Text;                                                                                           
using System.Windows.Forms;
using System.Media;

namespace Brick_Breaker
{
    public partial class BlockBreaker : Form
    {
        public BlockBreaker()
        {
            InitializeComponent();
        }
        //int Space    

        Random gen = new Random();                                                                      
        int px = 30;
        int py = 30;
        int Touch;
        int PaddleX = 590;
        int PaddleY = 970;
        int Lose;
        int Win;
        Graphics gfx;
        Bitmap bitmap;
        Rectangle paddleHitBox;

        SoundPlayer powerUpSound;
       
        bool left = false;
        bool right = false;

        SpeedPowerup sp;
        Timer powerupTimer;


        Ball ball;

        Paddle paddle;

        List<Brick> bricks;


        private void BlockBreaker_Load(object sender, EventArgs e)
        {
            powerUpSound = new SoundPlayer(Properties.Resources._8_Bit_Power_Up_Sound_Effect);
            sp = new SpeedPowerup (230, 500, 0 ,5, 100, 100, Color.Purple, Properties.Resources.Speed_Boost);
            bricks = new List<Brick>();
            ball = new Ball(900, 900, 4, -8, 50, 50);
            paddle = new Paddle(PaddleX, PaddleY, px, py, 250 , 100, Color.Aqua);
            
            //clears teh background to the original image                                                    
            bitmap = new Bitmap(ClientSize.Width, ClientSize.Height);
            gfx = Graphics.FromImage(bitmap);

            for (int x = 0; x < ClientSize.Width; x += BackgroundImage.Width)
            {
                for (int y = 0; y < ClientSize.Height; y += BackgroundImage.Height)
                {
                    gfx.DrawImage(BackgroundImage, new Point(x, y));
                }
            }
            gfx.FillRectangle(Brushes.Aquamarine, PaddleX, PaddleY, 250, 100);

            powerupTimer = new Timer();
            powerupTimer.Interval = 1000;
            powerupTimer.Tick += new EventHandler(powerupTimer_Tick);

            int gap = 5;
            int dy = 20;
            for (int row = 0; row < 10; row++)
            {
                int dx = 20;
                for (int col = 0; col < 12; col++)
                {
                    if (row == 0 || row == 1)
                    {
                        bricks.Add(new Brick(dx, dy, 150, 20, 3, Color.Red));
                    }
                    else if (row == 2 || row == 3)
                    {
                        bricks.Add(new Brick(dx, dy, 150, 20, 2, Color.Orange));
                    }
                    else
                    {
                        bricks.Add(new Brick(dx, dy, 150, 20, 1, Color.Green));
                    }

                    dx += 150 + gap;
                }
                dy += 25 + gap;
            }

            paddleHitBox = new Rectangle(PaddleX, PaddleY, 250, 100);

            label2.Text = string.Format("Bricks Left: {0}", bricks.Count);

            pictureBox1.Image = bitmap;

        }
        int timerTick = 0;
        void powerupTimer_Tick(object sender, EventArgs e)
        {
            timerTick++;
        }
        //Done                                                                                               
        private void BlockBreaker_MouseMove(object sender, MouseEventArgs e)
        {
            X_Y.Text = string.Format("X: {0}, Y: {1}", e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaddleX = 590;
            PaddleY = 970;
           // Start.Visible = false;
            this.Focus();

            gfx.FillRectangle(Brushes.Aquamarine, PaddleX, PaddleY, 250, 100);

            Paddle_Checker.Enabled = true;
        }

        private void Paddle_Checker_Tick(object sender, EventArgs e)
        {
            //clears the background to the original image                                                    

            for (int x = 0; x < ClientSize.Width; x += BackgroundImage.Width)
            {
                for (int y = 0; y < ClientSize.Height; y += BackgroundImage.Height)
                {
                    gfx.DrawImage(BackgroundImage, new Point(x, y));
                }
                label2.Text = string.Format("Bricks Left: {0}", bricks.Count);


            }

            paddle.hitbox = new Rectangle(paddle.X, paddle.Y, paddle.WIDTH, paddle.HEIGHT);
            //paddleHitBox = new Rectangle(PaddleX, PaddleY, 250, 100);

            if (sp.hitbox.IntersectsWith (paddle.hitbox))
            {
                sp.GivePowerup(paddle);
                if (!powerupTimer.Enabled)
                {
                    powerupTimer.Start();
                    powerUpSound.Play();
                }
                //make it invisible and move it off the screen 
                sp.Visible = false;
                sp.X = -1000;
            }
            if (timerTick >= 5)
            {
                paddle.SPEEDX = paddle.originalSpeed;
                timerTick = 0;
                powerupTimer.Stop();
            }
            //Done                                                                                           

            ball.Move(ClientSize);

            if (ball.y > ClientSize.Height)
            {
                Paddle_Checker.Enabled = false;
                //Start.Visible = true;
                Lose++;
                MessageBox.Show("You went off the screen");
                PaddleX = 590;
                PaddleY = 970;

                ball.x = 900;
                ball.y = 400;


            }

            //if (paddleHitBox.IntersectsWith(ball.hitbox))
            //{
            //    Touch++;
            //    ball.speedx *= -1;
            //    ball.speedy *= -1;

            //}

            if (paddle.hitbox.IntersectsWith(ball.hitbox))
            {
                int middleBall = ball.x + ball.hitbox.Width / 2;
                int middlePaddle = paddle.X + paddle.WIDTH / 2;

                Touch++;
                ball.speedy *= -1;

                if (middleBall > middlePaddle)
                {
                    ball.speedx = Math.Abs(ball.speedx);
                }
                else
                {
                    ball.speedx = -Math.Abs(ball.speedx);
                }
            }

            for (int i = 0; i < bricks.Count; i++)
            {
                if (ball.hitbox.IntersectsWith(bricks[i].hitbox))
                {
                    


                    bricks[i].hp--;
                    if (bricks[i].hp <= 0)
                    {
                        
                        if (gen.Next(1, 16) == 1)
                        {
                            sp.Visible = true;
                            sp.X = bricks[i].hitbox.X;
                            sp.Y = bricks[i].hitbox.Y;
                        }
                        bricks.RemoveAt(i);
                    }
                    Win++;
                    ball.speedy *= -1;
                    if (ball.speedx > 0 && (ball.speedx < 50 && ball.speedx > -50))
                    {
                        ball.speedx += 2;

                    }
                    if (ball.speedy > 0 && (ball.speedy < 25 && ball.speedy > -25))
                    {
                        ball.speedy += 3;

                    }

                }
            }
            sp.Fall();
            //if (left)
            //{
            //    PaddleX -= px;
            //    if (PaddleX + paddleHitBox.Width <= 0)
            //    {
            //        PaddleX = ClientSize.Width - 1;
            //    }
            //}
            //if (right)
            //{
            //    PaddleX += px;
            //    if (PaddleX > ClientSize.Width)
            //    {

            //        PaddleY = ClientSize.Width + 1;
            //    }
            //}

            if (left)
            {
               paddle.X -= paddle.SPEEDX;
            }
            if (right)
            {
                paddle.X += paddle.SPEEDX;
            }


            sp.Draw(gfx);
            gfx.FillRectangle(Brushes.Aquamarine, paddle.X, paddle.Y, 250, 100);
            ball.Draw(gfx);


            for (int i = 0; i < bricks.Count; i++)
            {
                bricks[i].Draw(gfx);
            }


            //set bitmap                                                                                     
            pictureBox1.Image = bitmap;


        }
        //rectangle on Circle & Paddel                                                                       
        private void BlockBreaker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                left = true;
            }
            if (e.KeyCode == Keys.S)
            {
                //initialize a variable; give it a limit; decide how to get there
                for (int i = 0; i < bricks.Count; i++)
                {
                    bricks[i].Erase(gfx, BackColor);
                }
                bricks = new List<Brick>();
                label2.Text = string.Format("Bricks Left: {0}", bricks.Count);
            }
            if (e.KeyCode == Keys.D)
            {
                right = true;
            }
        }

        private void BlockBreaker_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                left = false;
            }
            if (e.KeyCode == Keys.D)
            {
                right = false;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bricks.Count == 0)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                label1.Visible = true;
                Paddle_Checker.Enabled = false;
                pictureBox1.Visible = false;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
//                                                                                  Add Audio
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        Rectangle snakehitbox;
        Rectangle poisenhitbox;
        Rectangle food;
        int poisenx;
        int poiseny;
        int Score = 0;
        int foodx;
        int foody;
        Random randomGenerator = new Random();
        int count;
        int direction = 0; //0 = none, 1=up,2=right,3=left,4=down
        int SnakeX = 300;
        int SnakeY = 300;

        bool moving = false;

        List<Rectangle> tail;

        Graphics gfx;
        public Form1()
        {
            InitializeComponent();
        }
        //Move The Snake,
        private void Form1_Load(object sender, EventArgs e)
        {
            tail = new List<Rectangle>();
            gfx = CreateGraphics();

            //food stuff
            foodx = randomGenerator.Next(0, ClientSize.Width - pictureBox1.Width);
            foody = randomGenerator.Next(10, ClientSize.Height - pictureBox1.Height);
            pictureBox1.Location = new Point(foodx, foody);
            food = new Rectangle(foodx, foody, pictureBox1.Width, pictureBox1.Height);

            //poison stuff
            poisenx = randomGenerator.Next(0, ClientSize.Width - poisen.Width);
            poiseny = randomGenerator.Next(10, ClientSize.Height - poisen.Height);
            poisenhitbox = new Rectangle(poisenx, poiseny, poisen.Width, poisen.Height);
            poisen.Location = new Point(poisenx, poiseny);
            
            //snake stuff
            snakehitbox = new Rectangle(SnakeX, SnakeY, 20, 20);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = string.Format("X: {0}, Y: {1}", e.X, e.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //erase
            gfx.FillRectangle(new SolidBrush(BackColor), SnakeX, SnakeY, 20, 20);

            //add trail
            if (moving == true)
            {
                tail.Add(new Rectangle(SnakeX, SnakeY, 20, 20));
            }

            //moves & updates
            if (direction == 1)
            {
                SnakeY -= 20;
            }
            if (direction == 2)
            {
                SnakeX -= 20;
            }
            if (direction == 3)
            {
                SnakeX += 20;
            }
            if (direction == 4)
            {
                SnakeY += 20;
            }

            snakehitbox.X = SnakeX;
            snakehitbox.Y = SnakeY;

            //check for intersections
            
            for(int i = 0; i < tail.Count; i++)
            {
                if(snakehitbox.IntersectsWith(tail[i]))
                {
                    count++;
                    direction = int.MaxValue;
                    moving = false;
                    timer1.Enabled = false;
                    MessageBox.Show("You Lost ;(");
                    
                }
            }



            
            
            if (SnakeX < 0 || SnakeX > ClientSize.Width || SnakeY < 0 || SnakeY > ClientSize.Height)
            {
                direction = int.MaxValue;
                timer1.Enabled = false;
                moving = false;
                MessageBox.Show("You Stinck");
                count++;
            }
            if (snakehitbox.IntersectsWith(poisenhitbox))
            {
                count++;
                poisenx = randomGenerator.Next(0, ClientSize.Width - poisen.Width);
                poiseny = randomGenerator.Next(10, ClientSize.Height - poisen.Height);
                poisen.Location = new Point(poisenx, poiseny);
                poisenhitbox.X = poisenx;
                poisenhitbox.Y = poiseny;
            }
            if (snakehitbox.IntersectsWith(food))
            {
                Score++;
                foodx = randomGenerator.Next(0, ClientSize.Width - pictureBox1.Width);
                foody = randomGenerator.Next(10, ClientSize.Height - pictureBox1.Height);
                pictureBox1.Location = new Point(foodx, foody);
                food.X = foodx;
                food.Y = foody;
                //food.Width = pictureBox1.Width;
                //food.Height = pictureBox1.Height;

                //snakehitbox.Width = 20;
                //snakehitbox.Height = 10;

            }

            //draws and labels
            

            for (int i = 0; i < tail.Count; i++)
            {
                gfx.FillRectangle(Brushes.Red, tail[i] );
            }

            gfx.FillRectangle(Brushes.BlueViolet, SnakeX, SnakeY, 20, 20);

            label2.Text = string.Format("You Died {0} times", count);
            label5.Text = string.Format("You ate {0} times", Score);
            /**/
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W && direction != 4)
            {
                direction = 1;
                moving = true;

            }
            if (e.KeyCode == Keys.A && direction != 3)
            {
                direction = 2;
                moving = true;
            }
            if (e.KeyCode == Keys.D && direction != 2)
            {
                direction = 3;
                moving = true;
            }
            if (e.KeyCode == Keys.S && direction != 1)
            {
                direction = 4;
                moving = true;
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //restart
            tail.RemoveRange(0, tail.Count);
            gfx.Clear(BackColor);

            SnakeX = 300;
            SnakeY = 300;
            snakehitbox.Y = 300;
            snakehitbox.X = 300;

            button2.Text = "Refresh";
            timer1.Enabled = true;
            label2.Text = string.Format("You Died {0} times", count);
            label5.Text = string.Format("You ate {0} times", Score);
            pictureBox1.Visible = true;
            poisen.Visible = true;

        }














    }
}

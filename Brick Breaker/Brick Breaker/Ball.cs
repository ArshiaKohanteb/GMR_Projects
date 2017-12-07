using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Brick_Breaker
{
    class Ball
    {

        //variables
        //x y size color hitbox speedx speedy
        public int x;
        public int y;
        public int speedx;
        public int speedy;
        int height;
        int width;
        public Rectangle hitbox;
        //functions       

        //constructor
        public Ball(int X, int Y, int SpeedX, int SpeedY, int Height, int Width)
        {
            x = X;
            y = Y;
            width = Width;
            height = Height;
            speedx = SpeedX;
            speedy = SpeedY;
            hitbox = new Rectangle(x, y, width, height);
        }

        
        //move
        public void Move(Size ClientSize)
        {
            x += speedx;
            y += speedy;

            hitbox.X = x;
            hitbox.Y = y; 

            if (x + width > ClientSize.Width || x < 0)
            {
                speedx *= -1;
            }

            if (y < 0)
            {
                speedy *= -1;
            }

            
        }
         



        //draw

        public void Draw(Graphics gfx)
        {
            gfx.FillEllipse(Brushes.Gold, x, y, width, height);
        }




    }
}

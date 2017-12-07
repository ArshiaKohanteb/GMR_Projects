using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Brick_Breaker
{
    public class Paddle
    {
        public int X;
        public int Y;
        public int SPEEDX;
        public int SPEEDY;
        public int WIDTH;
        public int HEIGHT;
        public Color Tint;
        public Rectangle hitbox;
        public int originalSpeed;

        public Paddle(int x, int y, int speedx, int speedy, int width, int height, Color tint)
        {
            X = x;
            Y = y;
            originalSpeed = speedx;
            SPEEDX = speedx;
            SPEEDY = speedy;
            WIDTH = width;
            HEIGHT = height;
            Tint = tint;
            hitbox = new Rectangle(x, y, width, height);
        }

        public void Draw(Graphics gfx)
        {
            gfx.FillRectangle(new SolidBrush(Tint), X, Y, WIDTH, HEIGHT);
        }

        public void Erase(Graphics gfx, Color eraseColor)
        {
            gfx.FillRectangle(new SolidBrush(eraseColor), X, Y, WIDTH, HEIGHT);
        }
    
    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Brick_Breaker
{
    class Brick
    {

        //variables
        int x;
        int y;
        int width;
        int height;
        public Rectangle hitbox;
        public int hp;
        Color tint;

        //functions
        public Brick(int X, int Y, int Width, int Height, int HP, Color Tint)
        {
            x = X;
            y = Y;
            width = Width;
            height = Height;
            hp = HP;
            tint = Tint;
            hitbox = new Rectangle(x, y, width, height);
        }


        public void Draw(Graphics gfx)
        {
            gfx.FillRectangle(new SolidBrush(tint), x, y, width, height);
        }

        public void Erase(Graphics gfx, Color eraseColor)
        {
            gfx.FillRectangle(new SolidBrush(eraseColor), x, y, width, height);
        }
    }
}

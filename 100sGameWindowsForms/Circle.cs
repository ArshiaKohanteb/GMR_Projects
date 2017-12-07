using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace _100sGameWindowsForms
{
    class Circle
    {
        //variables
        int x;
        int y;
        int size;
        Rectangle hitbox;
        int speedx;
        int speedy;

        public Circle(int X, int Y, int Size, int Speedx, int Speedy)
        {
            x     = X;
            y     = Y;
            size = Size; 
            hitbox= new Rectangle(x, y, size, size);
            speedx= Speedx;
            speedy = Speedy;
        }

        //functions
        public void Move()
        {

        }

        public void Draw(Graphics gfx)
        {
            //gfx.DrawEllipse(Brushes.Gray
        }

        public void Erase(Graphics gfx)
        {
           // gfx clear();
        }

    }
}

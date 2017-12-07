using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Brick_Breaker
{
    //an abstract class is a class that can't be created, but is used to help create a base for other things to inherit from
    public abstract class Powerup
    {
        //needs coordinates, width, height
        
        public Image Img;
        public int X;
        public int Y;
        public int SPEEDX;
        public int SPEEDY;
        public int WIDTH;
        public int HEIGHT;
        public Color Tint;
        public Rectangle hitbox;

        int fallspeed;
        //abstract functions are functions that must be overidden by a class that inherits from this class
        public abstract void GivePowerup(Paddle paddleToPowerUp);

        public abstract void Fall();

        public abstract void Draw(Graphics gfx);
    }
}

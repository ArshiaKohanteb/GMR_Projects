using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Brick_Breaker
{
    public class SpeedPowerup : Powerup
    {

        public bool Visible;
       

        public SpeedPowerup(int x, int y, int speedx, int speedy, int width, int height, Color tint, Image img)
        :base()
        {
            X = x;
            Y = y;
            SPEEDX = speedx;
            SPEEDY = speedy;
            HEIGHT = height;
            WIDTH = width;
            Tint = tint;
            Img = img;
            hitbox = new Rectangle(x, y, width, height);
            Visible = true;
        }
        public override void GivePowerup(Paddle paddleToPowerUp)
        {
            if (SPEEDX != paddleToPowerUp.originalSpeed + 20)
            {
                paddleToPowerUp.SPEEDX += 20;
            }
        }

        public override void Draw(System.Drawing.Graphics gfx)
        {
            //get audio and image & make cool Stuffff
            if (Visible)
            {
                gfx.DrawImage(Img, X, Y, WIDTH, HEIGHT);
            }
        }

        public override void Fall()
        {
            Y += SPEEDY;
            hitbox.Y = Y;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace WindowsGame3
{
    public class Paddle : MovingSprite
    {
        bool al = false;
        bool dr = false;
        KeyboardState keystate;

        public Paddle(Texture2D image, Vector2 position, Color tint, int speedx, int speedy)
            : base(image, position, tint, speedx, speedy)
        {
        }
        public void Update(Viewport viewport)
        {
            keystate = Keyboard.GetState();
            if (dr == true && _position.X < viewport.Width - _image.Width)
            {
                _position.X += _speedx;
            }
            if (al == true && _position.X > 0)
            {
                _position.X -= _speedx;
            }

            if ((keystate.IsKeyDown(Keys.Right) || keystate.IsKeyDown(Keys.D))
                && _position.X < viewport.Width - _image.Width)
            {
                dr = true;
                al = false;
            }
            if ((keystate.IsKeyDown(Keys.Left) || keystate.IsKeyDown(Keys.A))
                && _position.X > 0)
            {
                dr = false;
                al = true;
                
            }
        }//_position.X < 0
    }

}

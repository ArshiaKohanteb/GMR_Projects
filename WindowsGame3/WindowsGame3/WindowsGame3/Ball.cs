using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace WindowsGame3
{
    public class Ball : MovingSprite
    {
        public int deaths = 0;
        public Ball(Texture2D image, Vector2 position, Color tint, int speedx, int speedy)
            : base(image, position, tint, speedx, speedy)
        {

        }

        public void Move(Viewport viewport)
        {
            _position.X += _speedx;
            _position.Y += _speedy;

            if (_position.X + _image.Width > viewport.Width || _position.X < 0)
            {
                _speedx *= -1;
            }

            if (_position.Y < 0)
            {
                _speedy *= -1;
            }
            if (_position.Y > viewport.Height)
            {
                deaths++;
                _position.X = 700;
                _position.Y = 500;
                _speedy *= -1;
            }
        }
    }
}

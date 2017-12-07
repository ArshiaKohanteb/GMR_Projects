using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace WindowsGame3
{
    public class Sprite
    {
        public Texture2D _image;
        public Vector2 _position;
        public Color _tint;
        public Rectangle _hitBox;
        public Rectangle _hitBoxx1;
        public Rectangle _hitBoxx2;
        public Rectangle _hitBoxy1;
        public Rectangle _hitBoxy2;
        public int speedx2;

        //Constructor: very FIRST function that runs when you make an object out of a class.
        public Sprite(Texture2D image, Vector2 position, Color tint)
        {
            _image = image;
            _position = position;
            _tint = tint;
        }

        public void HitBoxUpdate()
        {
            _hitBox = new Rectangle((int)_position.X, (int)_position.Y, _image.Width, _image.Height);
            _hitBoxx1 = new Rectangle((int)_position.X, (int)_position.Y, _image.Width, _image.Height);
            _hitBoxx2 = new Rectangle((int)_position.X + _hitBox.Width, (int)_position.Y, _image.Width, _image.Height);
            _hitBoxy1 = new Rectangle((int)_position.X, (int)_position.Y, _image.Width, _image.Height);
            _hitBoxy2 = new Rectangle((int)_position.X, (int)_position.Y + _hitBox.Height, _image.Width, _image.Height);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_image, _position, _tint);
        }

       

    }
}




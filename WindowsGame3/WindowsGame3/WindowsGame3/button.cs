using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace WindowsGame3
{
    public class Button : Sprite
    {
        private MouseState _ms;
        public int _brickAmount;
        public bool isClicked = false;


        public Button(Texture2D image, Vector2 position, Color tint, int brickAmount)
            : base(image, position, tint)
        {
            _brickAmount = brickAmount;
        }
        public void update(GameTime gameTime)
        {
            _hitBox = new Rectangle((int)_position.X, (int)_position.Y, _image.Width, _image.Height);
            _ms = Mouse.GetState();
            if (_hitBox.Contains(_ms.X, _ms.Y) && _ms.LeftButton == ButtonState.Pressed)
            {
                isClicked = true;
            }
            else
            {
                isClicked = false;
            }
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace WindowsGame3
{
    public class MovingSprite : Sprite
    {
        public int _speedx;
        public int _speedy;

        //Constructor: very FIRST function that runs when you make an object out of a class.
        public MovingSprite(Texture2D image, Vector2 position, Color tint, int speedx, int speedy)
            : base(image, position, tint)
        {
            _speedx += speedx;
            _speedy += speedy;
            speedx2 = _speedx;
        }
    }        
}            
             
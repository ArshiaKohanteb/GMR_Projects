using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace SnakeXNA
{
    class food
    {
        public Texture2D _mouseface;
        public Vector2 _mouseposition;
        Color _tint;
        //Constructor: very FIRST function that runs when you make an object out of a class.
        public food(Texture2D mouseface, Vector2 mouseposition, Color tint)
        {
            _mouseface = mouseface;
            _mouseposition = mouseposition;
            _tint = tint;
        }

    }
}

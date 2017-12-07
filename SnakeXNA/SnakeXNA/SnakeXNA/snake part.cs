using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace SnakeXNA
{
    class snake_part
    {
        public Texture2D _snakeface;
        public Vector2 _snakeposition;
        Color _tint;
        //Constructor: very FIRST function that runs when you make an object out of a class.
        public snake_part(Texture2D snakeface, Vector2 snakeposition, Color tint)
        {
            _snakeface = snakeface;
            _snakeposition = snakeposition;
            _tint = tint;
        }
        
        public void HitBoxUpdate()
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Brick_Breaker_Xna
{
    class Sprite
    {
        Vector2 _position;
        Texture2D _Image;
        Color _tint;
        Rectangle _hitbox;

        public Sprite (Vector2 position, Texture2D Image, Color tint, Rectangle hitbox)
        {
            _position = position;
            _Image = Image;
            _tint = tint;
            _hitbox = hitbox;
        }
    }
}

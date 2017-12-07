using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace ArshiaXNA
{
    
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Vector2 Position;
        Texture2D Image;
        Color color;
        Vector2 Position1;
        Texture2D Image1;
        Color color1;
        Vector2 Position2;
        Texture2D Image2;
        Color color2;
        int speedx2 = 1;
        int speedy2 = 1;
        int speedx1 = 1;
        int speedy1 = 1;
        int speedx = 1;
        int speedy = 1;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        
        protected override void Initialize()
        {
            IsMouseVisible = true;
            graphics.PreferredBackBufferWidth = 1920;
            graphics.PreferredBackBufferHeight = 1080;
            graphics.ApplyChanges();

            base.Initialize();
        }

        
        protected override void LoadContent()
        {
            
            spriteBatch = new SpriteBatch(GraphicsDevice);

            color = Color.BlanchedAlmond;
            Position = new Vector2(100, 88);
            Image = Content.Load<Texture2D>("Basketball");
            
            spriteBatch = new SpriteBatch(GraphicsDevice);

            color1 = Color.BlanchedAlmond;
            Position1 = new Vector2(511, 169);
            Image1 = Content.Load<Texture2D>("Basketball");

            spriteBatch = new SpriteBatch(GraphicsDevice);

            color2 = Color.BlanchedAlmond;
            Position2 = new Vector2(725 , 209);
            Image2 = Content.Load<Texture2D>("Kobe Bryant");
        }

        
        protected override void UnloadContent()
        {

        }

       
        protected override void Update(GameTime gameTime)
        {
            Position1.X += speedx1;
            Position1.Y += speedy1;

            if (Position1.X + Image1.Width > GraphicsDevice.Viewport.Width || Position1.X < 0)
            {
               speedx1 *= -1;
            }

            if (Position1.Y + Image1.Height > GraphicsDevice.Viewport.Height || Position1.Y < 0)
            {
                speedy1 *= -1;
            }

            Position.X += speedx;
            Position.Y += speedy;

            if (Position.X + Image.Width > GraphicsDevice.Viewport.Width || Position.X < 0)
            {
                speedx *= -1;
            }

            if (Position.Y + Image.Height > GraphicsDevice.Viewport.Height || Position.Y < 0)
            {
                speedy *= -1;
            }

            Position2.X += speedx2;
            Position2.Y += speedy2;

            if (Position2.X + Image2.Width > GraphicsDevice.Viewport.Width || Position2.X < 0)
            {
                speedx2 *= -1;
            }

            if (Position2.Y + Image2.Height > GraphicsDevice.Viewport.Height || Position2.Y < 0)
            {
                speedy2 *= -1;
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            spriteBatch.Draw(Image, Position, color);
            spriteBatch.End();
            spriteBatch.Begin();
            spriteBatch.Draw(Image1, Position1, color1);
            spriteBatch.End();
            spriteBatch.Begin();
            spriteBatch.Draw(Image2, Position2, color2);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}

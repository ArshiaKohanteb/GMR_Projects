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

namespace WindowsGame1
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Vector2 Position1;
        Texture2D Image1;
        Color Color1;
        int speedx = 5;
        int speedy = 5;
        Vector2 Position2;
        Texture2D Image2;
        Color Color2;
        int speedx2 = 5;
        int speedy2 = 5;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            Image1 = Content.Load<Texture2D>("$RC2TGRY");
            Position1 = new Vector2(300, 300);
            Color1 = Color.White;
            Image2 = Content.Load<Texture2D>("$RNUSMYI");
            Position2 = new Vector2(200, 150);
            Color2 = Color.White;
        }

        /// <summary>
        ///UnloadContent will be called once per game and is the place to unload
        ///all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here
            Position1.X += speedx;
            Position1.Y += speedy;
            Position2.X += speedx2;
            Position2.Y += speedy2;
            base.Update(gameTime);
            if (Position1.X + Image1.Width >= GraphicsDevice.Viewport.Width)
            {
                speedx *= -1;
            }
            else if(Position1.X <= 0)
            {
                speedx *= -1;
            }
            else if (Position1.Y + Image1.Height  >= GraphicsDevice.Viewport.Height)
            {
                speedy *= -1;
            }
            else if(Position1.Y <= 0)
            {
                speedy *= -1;
            }
            if (Position2.X + Image2.Width >= GraphicsDevice.Viewport.Width)
            {
                speedx *= -1;  
            }
        
        
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.MediumSpringGreen);

            spriteBatch.Begin();

            spriteBatch.Draw(Image1, Position1, Color1);
            spriteBatch.Draw(Image2, Position2, Color2);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
///NEXT CLASS MAKE IMAGE 2 MOVE AND TELL BEN OLD PROG
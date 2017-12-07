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

namespace WindowsGame3
{
    /// <summary>
    /// take the pics and make an option to select amount of balls
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        bool addBrick = true;
        bool gameStart = false;
        bool gamend = false;
        public Button n25;
        public Button n75;
        public Button n150;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        List<Ball> balls = new List<Ball>();
        public List<Brick> bricks = new List<Brick>();
        Paddle paddle;
        bool isPaused = false;

        Song booSound;


        SpriteFont font;
        string text;
        Vector2 textPosition;
        Color textColor;
        SpriteFont font1;
        string text1;
        Vector2 textPosition1;
        Color textColor1;
        Brick tempBrick;
        Random rand = new Random();
        Texture2D brickImage;
        Texture2D ballImage;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        protected override void Initialize()
        {
            IsMouseVisible = true;
            graphics.PreferredBackBufferHeight = 800;
            graphics.PreferredBackBufferWidth = 1500;
            graphics.ApplyChanges();
            base.Initialize();
        }
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            n25 = new Button(Content.Load<Texture2D>("25"), new Vector2(300, 300), Color.AliceBlue, 25);
            n75 = new Button(Content.Load<Texture2D>("75"), new Vector2(600, 300), Color.AliceBlue, 75);
            n150 = new Button(Content.Load<Texture2D>("150"), new Vector2(900, 300), Color.AliceBlue, 150);
            paddle = new Paddle(Content.Load<Texture2D>("Paddle"), new Vector2(650, 763), Color.White, 20, 0);

            ballImage = Content.Load<Texture2D>("Ball");
            brickImage = Content.Load<Texture2D>("Brick");
            font = Content.Load<SpriteFont>("spriteFont");
            font1 = Content.Load<SpriteFont>("spritefont");
            text = "";

            booSound = Content.Load<Song>("Boo");


        }

        private void createBricks(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                do
                {
                    addBrick = true;
                    tempBrick = new Brick(brickImage, new Vector2(rand.Next(0, GraphicsDevice.Viewport.Width - brickImage.Width), rand.Next(0, GraphicsDevice.Viewport.Height / 3)), Color.White);

                    tempBrick.HitBoxUpdate();
                } while (!addBrick);
                bricks.Add(tempBrick);
            }
            for (int i = 0; i < 1; i++)
            {
                balls.Add(new Ball(ballImage, new Vector2(rand.Next(0, GraphicsDevice.Viewport.Width - ballImage.Width), rand.Next(0, GraphicsDevice.Viewport.Height / 2)), Color.White, 10, 10));
            }
        }

        protected override void Update(GameTime gameTime)
        {
            
            if (gamend == true) 
            {
                while (MediaPlayer.State != MediaState.Playing)
                {
                    MediaPlayer.Play(booSound);
                }
                
                
            }
            text1 = string.Format("You Lost");
            textPosition1 = new Vector2(500, 500);
            textColor1 = Color.Turquoise;

            if (gameStart == false)
            {
                n25.update(gameTime);
                n75.update(gameTime);
                n150.update(gameTime);
                if (n25.isClicked)
                {
                    gameStart = true;
                    createBricks(n25._brickAmount);
                }
                if (n75.isClicked)
                {
                    gameStart = true;
                    createBricks(n75._brickAmount);
                }
                if (n150.isClicked)
                {
                    gameStart = true;
                    createBricks(n150._brickAmount);
                }
            }
            else
            {
                int deaths = 0;
                for (int i = 0; i < balls.Count; i++)
                {
                    deaths += balls[i].deaths;
                }
                text = string.Format("You died {0} times & youre going to lose", deaths);
                textPosition = new Vector2(00, 700);
                textColor = Color.YellowGreen;
                
               
                paddle.Update(GraphicsDevice.Viewport);

                if (deaths == 5)
                {gamend = true;}
                if (isPaused)
                {
                    MouseState ms = Mouse.GetState();
                    if (ms.LeftButton == ButtonState.Pressed)
                    {
                        isPaused = false;
                    }
                }
                else
                {
                    paddle.HitBoxUpdate();
                    for (int i = 0; i < balls.Count; i++)
                    {
                        balls[i].Move(GraphicsDevice.Viewport);
                        balls[i].HitBoxUpdate();
                        if (paddle._hitBox.Intersects(balls[i]._hitBox))
                        {
                            balls[i]._speedy *= -1;
                        }
                        //////////////////////////////////////////////////////////////////////////////////////////////////////////
                        for (int j = 0; j < bricks.Count; j++)
                        {
                            bricks[j].HitBoxUpdate();

                            if (bricks[j]._hitBoxx1.Intersects(balls[i]._hitBoxx1))
                            {
                                balls[i]._speedy *= -1;
                                bricks.RemoveAt(j);
                                j--;
                            }

                        }
                        //////////////////////////////////////////////////////////////////////////////////////////////////////////
                        for (int j = 0; j < bricks.Count; j++)
                        {
                            bricks[j].HitBoxUpdate();

                            if (bricks[j]._hitBoxx2.Intersects(balls[i]._hitBoxx2))
                            {
                                balls[i]._speedy *= -1;
                                bricks.RemoveAt(j);
                                j--;
                            }

                        }
                        //////////////////////////////////////////////////////////////////////////////////////////////////////////
                        for (int j = 0; j < bricks.Count; j++)
                        {
                            bricks[j].HitBoxUpdate();

                            if (bricks[j]._hitBoxy1.Intersects(balls[i]._hitBoxy1))
                            {
                                balls[i]._speedy *= -1;
                                bricks.RemoveAt(j);
                                j--;

                            }

                        }
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
                        for (int j = 0; j < bricks.Count; j++)
                        {
                            bricks[j].HitBoxUpdate();

                            if (bricks[j]._hitBoxy2.Intersects(balls[i]._hitBoxy2))
                            {
                                balls[i]._speedy *= -1;
                                bricks.RemoveAt(j);
                                j--;


                            }

                        }

                    }

                }
            }


            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(new Color(129, 129, 129));
            spriteBatch.Begin();
            if (gameStart == false)
            {
                n25.Draw(spriteBatch);
                n75.Draw(spriteBatch);
                n150.Draw(spriteBatch);
            }
            else
            {
                if (gamend == false)
                {
                    for (int i = 0; i < balls.Count; i++)
                    {
                        balls[i].Draw(spriteBatch);
                    }
                    for (int i = 0; i < bricks.Count; i++)
                    {
                        bricks[i].Draw(spriteBatch);
                    }
                    paddle.Draw(spriteBatch);
                    
                    spriteBatch.DrawString(font, text, textPosition, textColor);
                }
                if (gamend == true)
                {
                    spriteBatch.DrawString(font1, text1, textPosition1, textColor1);
                }
            
            }

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
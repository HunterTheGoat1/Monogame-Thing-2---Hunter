using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Thing_2___Hunter
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D circleTexture;
        private Texture2D rectangleTexture;
        private Rectangle Head;
        private Rectangle Mouth;
        private Rectangle Nose;
        private Rectangle eyeOne;
        private Rectangle eyeTwo;
        private Rectangle eyeOneDot;
        private Rectangle eyeTwoDot;
        private Rectangle eyeOneOutline;
        private Rectangle eyeTwoOutline;
        SpriteFont TitleFont;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            Head = new Rectangle(275, 25, 300, 300);
            Mouth = new Rectangle(375, 250, 100, 20);
            Nose = new Rectangle(415, 170, 20, 20);
            eyeOne = new Rectangle(300, 100, 50, 50);
            eyeTwo = new Rectangle(500, 100, 50, 50);
            eyeOneDot = new Rectangle(315, 115, 20, 20);
            eyeTwoDot = new Rectangle(515, 115, 20, 20);
            eyeOneOutline = new Rectangle(295, 95, 60, 60);
            eyeTwoOutline = new Rectangle(495, 95, 60, 60);
            this.Window.Title = "Hunter's Drawing";
            _graphics.PreferredBackBufferWidth = (800);
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            circleTexture = Content.Load<Texture2D>("circle");
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            TitleFont = Content.Load<SpriteFont>("TitleFont");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            _spriteBatch.DrawString(TitleFont, "Hello There!", new Vector2(100, 0), Color.Black);
            _spriteBatch.Draw(circleTexture, Head, Color.Yellow);
            _spriteBatch.Draw(rectangleTexture, Nose, Color.Black);
            _spriteBatch.Draw(rectangleTexture, Mouth, Color.Black);
            _spriteBatch.Draw(circleTexture, eyeOneOutline, Color.Black);
            _spriteBatch.Draw(circleTexture, eyeTwoOutline, Color.Black);
            _spriteBatch.Draw(circleTexture, eyeOne, Color.White);
            _spriteBatch.Draw(circleTexture, eyeTwo, Color.White);
            _spriteBatch.Draw(circleTexture, eyeOneDot, Color.Brown);
            _spriteBatch.Draw(circleTexture, eyeTwoDot, Color.Brown);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
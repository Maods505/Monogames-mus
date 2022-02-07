using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace _2022_01_18
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D parrotBild, zebraBild;
        Vector2 parrotPosition = new Vector2(100, 200);
        Vector2 zebraPosition = new Vector2(400, 30);
        Vector2 parrotHastighet = new Vector2(2, 1);
        MouseState mus;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";                   
        }

        protected override void Initialize()
        {
            IsMouseVisible = true;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            parrotBild = Content.Load<Texture2D>("parrot");
            zebraBild = Content.Load<Texture2D>("zebra");
        }

        protected override void Update(GameTime gameTime)
        {
            mus = Mouse.GetState();
            parrotPosition.X = mus.X;
            parrotPosition.Y = mus.Y;
            zebraPosition.X = mus.X;
            zebraPosition.Y = mus.Y;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Tomato);

            spriteBatch.Begin();
            spriteBatch.Draw(parrotBild, parrotPosition, Color.White);
            spriteBatch.Draw(zebraBild, zebraPosition, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}

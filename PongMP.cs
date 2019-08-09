using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using PongMP.GameElements;

namespace PongMP
{
    public class PongMP : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        GameRenderer gameRenderer;

        public PongMP()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            gameRenderer = new GameRenderer(GraphicsDevice);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            gameRenderer.RegisterGameElementElement(new BallElement(GraphicsDevice, 0, Color.White, 0, 0));
        }

        protected override void UnloadContent()
        {
            gameRenderer.UnloadGame();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (Keyboard.GetState().IsKeyDown(Keys.R))
            {
                gameRenderer.FindElement(0).MoveTo(0, 0);
            }

            gameRenderer.UpdateGame(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();
            gameRenderer.DrawGame(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
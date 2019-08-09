using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace pong_mp
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
            gameRenderer = new GameRenderer();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            gameRenderer.RegisterGameElementElement(new GameElement(GraphicsDevice, 0, 0, 0, 50, 50, Color.White));
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            gameRenderer.UpdateGame();

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
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using PongMP.GameElements;
using PongMP.Gamemodes;

namespace PongMP
{
    public class PongMP : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public static Gamemode currentGamemode;

        public PongMP()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            currentGamemode = new PlayMode(new GameRenderer(GraphicsDevice), null, GraphicsDevice);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            currentGamemode.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();
            currentGamemode.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
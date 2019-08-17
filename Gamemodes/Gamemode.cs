using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using PongMP;

namespace PongMP.Gamemodes
{
    public class Gamemode
    {
        public readonly string Name;
        public GameRenderer GameRenderer;
        public UIRenderer UiRenderer;

        public GraphicsDevice GraphicsDevice;

        public Gamemode(string name, GameRenderer gameRenderer, UIRenderer uiRenderer, GraphicsDevice graphicsDevice)
        {
            Name = name;
            GameRenderer = gameRenderer;
            UiRenderer = uiRenderer;
            GraphicsDevice = graphicsDevice;
        }

        virtual public void InitializeGame()
        {

        }

        virtual public void InitializeUI()
        {

        }

        virtual public void Update(GameTime time)
        {
            GameRenderer?.UpdateGame(time);
            UiRenderer?.UpdateUI(time);
        }

        virtual public void Draw(SpriteBatch spriteBatch) {
            GameRenderer?.DrawGame(spriteBatch);
            UiRenderer?.DrawUI(spriteBatch);
        }

        public string GetCurrentMode() {
            return Name;
        }

    }
}
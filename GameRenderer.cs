using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using PongMP.GameElements;

namespace PongMP
{
    public class GameRenderer
    {

        List<GameElement> GameElements = new List<GameElement>();
        public Rectangle GameArea;
        GraphicsDevice graphicsDevice;
        public GameRenderer(GraphicsDevice graphicsDevice)
        {
            this.graphicsDevice = graphicsDevice;
            GameArea = new Rectangle(0, 0, graphicsDevice.Viewport.Bounds.Width, graphicsDevice.Viewport.Bounds.Height);
        }

        public void UpdateGame(GameTime gameTime)
        {
            foreach (GameElement element in GameElements)
            {
                element.Update(gameTime);
            }
        }
        public void DrawGame(SpriteBatch spriteBatch)
        {
            foreach (GameElement element in GameElements)
            {
                element.Draw(spriteBatch);
            }
        }

        public void RegisterGameElementElement(GameElement element)
        {
            element.SetRenderer(this);
            GameElements.Add(element);
        }

        public GameElement FindElement(int id)
        {
            foreach (GameElement element in GameElements)
            {
                if (element.id == id)
                {
                    return element;
                }
            }
            return null;
        }

        public void UnloadGame() {
            foreach (GameElement element in GameElements)
            {
                element.Unload();
            }
        }


    }
}

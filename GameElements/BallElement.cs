using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PongMP.GameElements
{
    public class BallElement : GameElement
    {
        public float velocityX = 1f, velocityY = 1f;
        public BallElement(GraphicsDevice graphicsDevice, int id, Color color, int X, int Y, int Width = 10, int Height = 10) : base(graphicsDevice, id, color, X, Y, Width, Height)
        {

        }

        override public void Update(GameTime gameTime)
        {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            float timeScale = deltaTime / 16.667f;
            MoveBy(velocityX * timeScale, velocityY * timeScale);
        }

        
    }
}
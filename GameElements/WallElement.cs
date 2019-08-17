using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace PongMP.GameElements
{
    public class WallElement : GameElement
    {
        public WallElement(GraphicsDevice graphicsDevice, string id, float X, float Y, int Width, int Height) : base(graphicsDevice, id, Color.LightGray, X, Y, Width, Height)
        {

        }

        override public void Update(GameTime gameTime)
        {
            BallElement ball = (BallElement) PongMP.currentGamemode.GameRenderer.FindElement("ball");
            // Test ball colision
            Rectangle ballBoundries = ball.GetRectangle();
            if (Utils.AreRegionColliding(ballBoundries, GetRectangle())) {
                // Bounce the ball
                ball.velocityY *= -1;
            }
            base.Update(gameTime);
        }
    }
}
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using PongMP.GameElements;

namespace PongMP.Gamemodes
{
    public class PlayMode : Gamemode
    {
        public PlayMode(GameRenderer gameRenderer, UIRenderer uiRenderer, GraphicsDevice graphicsDevice) : base("play_mode", gameRenderer, uiRenderer, graphicsDevice)
        {
            InitializeGame();
        }

        override public void InitializeGame()
        {
            GameRenderer.RegisterGameElementElement(new BallElement(GraphicsDevice, "ball", 100, 100));
            GameRenderer.RegisterGameElementElement(new WallElement(GraphicsDevice, "wall_bot", 20, 445, 760, 15));
            GameRenderer.RegisterGameElementElement(new WallElement(GraphicsDevice, "wall_top", 20, 20, 760, 15));
        }

        override public void Update(GameTime time)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.R))
            {
                GameRenderer.FindElement("ball").MoveTo(0, 0);
            }
            base.Update(time);
        }
    }
}
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PongMP.GameElements
{
    public class GameElement
    {
        public readonly string id;
        public float X;
        public float Y;
        public int Width;
        public int Height;
        public Color Color;
        Texture2D texture;
        public GameRenderer renderer;
        public GameElement(GraphicsDevice graphicsDevice, string id, Color color, float X, float Y, int Width, int Height)
        {
            this.id = id;
            this.X = X;
            this.Y = Y;
            this.Width = Width;
            this.Height = Height;
            Color = color;
            texture = new Texture2D(graphicsDevice, 1, 1);
            texture.SetData(new[] { Color.White });
        }

        virtual public void MoveTo(float destX, float destY)
        {
            X = destX;
            Y = destY;
        }

        virtual public void MoveBy(float movX, float movY)
        {
            X += movX;
            Y += movY;
        }

        virtual public void Resize(int newWidth, int newHeight)
        {
            Width = newWidth;
            Height = newHeight;
        }

        virtual public void Draw(SpriteBatch spriteBatch) => spriteBatch.Draw(texture, new Rectangle((int)X, (int)Y, Width, Height), Color);

        virtual public void Update(GameTime gameTime)
        {

        }

        virtual public void Unload() => texture.Dispose();

        virtual public Rectangle GetRectangle() => new Rectangle((int)X, (int)Y, Width, Height);

        public void SetRenderer(GameRenderer renderer) {
            this.renderer = renderer;
        }

        public bool IsInGameArea() {
            return Utils.IsInBounds(GetRectangle(), renderer.GameArea);
        }


    }
}

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class GameElement
{
    public readonly int id;
    public int X;
    public int Y;
    public int Width;
    public int Height;
    public Color Color;
    Texture2D texture;
    public GameElement(GraphicsDevice graphicsDevice, int id, int X, int Y, int Width, int Height, Color color)
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

    public void Move(int destX, int destY)
    {
        X = destX;
        Y = destY;
    }

    public void Resize(int newWidth, int newHeight)
    {
        Width = newWidth;
        Height = newHeight;
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(texture, new Rectangle(X, Y, Width, Height), Color);
    }

    public void Update() {

    }

    public void Unload()
    {
        texture.Dispose();
    }


}
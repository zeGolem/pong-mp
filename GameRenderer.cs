using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;

public class GameRenderer {

    List<GameElement> GameElements = new List<GameElement>();
    public GameRenderer() {

    }

    public void UpdateGame() {
        foreach (GameElement element in GameElements)
        {
            element.Update();
        }
    }
    public void DrawGame(SpriteBatch spriteBatch) {
        foreach (GameElement element in GameElements)
        {
            element.Draw(spriteBatch);
        }
    }

    public void RegisterGameElementElement(GameElement element) {
        GameElements.Add(element);
    }

    public GameElement FindElement(int id) {
        foreach (GameElement element in GameElements)
        {
            if (element.id == id) {
                return element;
            }
        }
        return null;
    }
}
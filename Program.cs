using System;

namespace PongMP
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new PongMP())
                game.Run();
        }
    }
}

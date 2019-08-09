using System;

namespace pong_mp
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

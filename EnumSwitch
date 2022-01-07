using System;

namespace EnumSwitch
{
    enum Gameflow { Start, Playing, Pause, GameOver }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Gameflow gameflow = Gameflow.Start;
            string GameState = "";

            switch (gameflow)
            {
                case Gameflow.Start:
                    GameState = "Start Game";
                    break;

                case Gameflow.Playing:
                    GameState = "Playing Game";
                    break;

                default:
                    break;
            }

            Console.WriteLine(GameState);
        }
    }
}

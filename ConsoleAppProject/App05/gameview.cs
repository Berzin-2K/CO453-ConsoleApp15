using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App05
{
    public class GameView
    {
        private Game game;
        public void StartGame()
        {
            SetupConsole();

            ConsoleHelper.OutputHeading(" Fire-Ice-Wind game ");

            if (game == null)
            {
                Console.Write(" Please enter your Name > ");
                string name = Console.ReadLine();

                game = new Game("Berzin");
            }
            game.Start();
        }
        private void SetupConsole()
        {
            Console.SetWindowSize(100, 40);
            Console.SetBufferSize(100, 40);

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
        }
    }

}


using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App05
{
    public class GameView
    {
        private Game game;

        public void play()
        {
            bool wantToQuit = true;

            do
            {
                StartGame();
                getPlayerChoice();
                DisplayChoice(game.human.Choice);
                game.MakeComputerChoice();
                DisplayChoice(game.computer.Choice);
                 game.ScoreRound();
                if (game.Round == game.LastRound)
                {
                    Console.WriteLine();
                }

            } while (!wantToQuit);
        }

        private void DisplayChoice(GameChoices choice)
        {
            throw new NotImplementedException();
        }

        private void getPlayerChoice()
        {
            throw new NotImplementedException();
        }

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

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
        }
    }

}


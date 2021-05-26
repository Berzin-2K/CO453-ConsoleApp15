using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App05
{
   public class Game
    {
        public const int MAXIMUM_ROUND = 10;

        public int Round { get; set; }
        public int LastRound { get; set; }
        public Player human { get; }

        public Player computer { get; }

        public Player CurrentPlayer { get; set;  }

        public Player winner { get; set; }

        public Game(string name)
        {
            human = new Player("Berzin", GamePlayers.Player);
            computer = new Player("CPU", GamePlayers.Computer);

            Round = 0;
        }

        public void  Start()
        {
            Round = 1;
            LastRound = 3;
            CurrentPlayer = human;

            human.Score = 0;
            computer.Score = 0;


        }

        private Random generator = new Random(55);



        public void MakeComputerChoice()
        {
            int choice = generator.Next(1, 4);
            switch(choice)
            {
                case 1: computer.Choice = GameChoices.Ice; break;
                case 2: computer.Choice = GameChoices.Fire; break;
                case 3: computer.Choice = GameChoices.Wind; break;
            }
        }

        public void ScoreRound()
        {
            if (human.Choice == GameChoices.Fire &&
                computer.Choice == GameChoices.Wind)
            {
                computer.Score += 2;
                winner = computer;
            }
            if (human.Choice == GameChoices.Ice &&
                computer.Choice == GameChoices.Fire)
            {
                computer.Score += 2;
                winner = computer;
            }
            if (human.Choice == GameChoices.Wind &&
                computer.Choice == GameChoices.Ice)
            {
                computer.Score += 2;
                winner = computer;
            }
            if (Round < LastRound)
            {
                Round++;
            }
            else End();

        }

        public void End()
        {
            if (computer.Score > human.Score)
            {
                winner = computer;
            }
            if (computer.Score < human.Score)
            {
                winner = human;
            }
            else winner = null;
        }
    }
}

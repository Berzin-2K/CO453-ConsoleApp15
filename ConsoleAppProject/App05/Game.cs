using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App05
{
   public class Game
    {
        public const int MAXIMUM_ROUND = 10;

        public int Round { get; set; }

            public Player human { get; }

        public Player computer { get; }

        public Player CurrentPlayer { get; }

        public Player winner { get; }

        public Game(string name)
        {
            human = new Player("Berzin", GamePlayers.Player);
            computer = new Player("CPU", GamePlayers.Computer);

            Round = 0;
        }

        public void start Start()
        {
            Round = 1;
            CurrentPlayer = human;

            human.Score = 0;
            computer.Score = 0;


        }





        public void End()
        {
            if (computer.Score > human.Score)
            {
                Winner = computer;
            }
            else if (computer.Score < human.Score)
            {
                Winner = human;
            }
            else winner = null;
        }

       
    }
}

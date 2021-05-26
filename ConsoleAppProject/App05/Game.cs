﻿using System;
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
        }
    }
}

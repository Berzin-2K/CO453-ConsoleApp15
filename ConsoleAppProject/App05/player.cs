using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App05
{
    public class Player
    {
        public string Name { get; }

        public int Score { get; set; }

        public GamePlayers PlayerType { get; }

        public GameChoices Choice { get; set; }

        public Player (string name, GamePlayers PlayerType)
        {
            this.Name = name;
            this.PlayerType = PlayerType;
            Score = 0;
            Choice = GameChoices;
        }


    }
}

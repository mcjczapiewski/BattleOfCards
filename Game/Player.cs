using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards.Game
{
    class Player
    {
        public string Name { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        public void Choose()
        {
            throw new NotImplementedException();
        }
    }
}

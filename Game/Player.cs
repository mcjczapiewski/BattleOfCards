using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards.Game
{
    public class Player
    {
        public string Name { get; set; }

        public Hand handOfCards;

        public Player(string name, Hand handOfCards)
        {
            Name = name;
            this.handOfCards = handOfCards;
        }

        public int ChooseAtribute(Card card)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards.Game
{
    public class Player
    {
        //public List<Card> handOfCards;

        public string Name { get; set; }
        public List<Card> HandOfCards = new List<Card>();

        public Player(string name)
        {
            Name = name;
        }

        public int ChooseAtribute(Card card)
        {
            throw new NotImplementedException();
        }

        public Card PlayCard()
        {
            Card cardToPlay = this. HandOfCards[0];
            handOfCards.RemoveAt(0);

            return cardToPlay;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards.Game
{
    public class Player
    {
        public List<Card> handOfCards;

        public string Name { get; set; }


        public Player(string name, List<Card> handOfCards)
        {
            Name = name;
            this.handOfCards = handOfCards;
        }

        public int ChooseAtribute(Card card)
        {
            throw new NotImplementedException();
        }

        public Card PlayCard()
        {
            Card cardToPlay = handOfCards[0];
            handOfCards.RemoveAt(0);

            return cardToPlay;
        }
    }
}

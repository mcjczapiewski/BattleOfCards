using BattleOfCards.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards.Game
{
    public class DeckOfCards
    {
        public DeckOfCards(List<Card> cards)
        {
            Cards = cards;
        }

        public List<Card> Cards { get; set; }

        public void ShuffledCards(List<Card> cards)
        {
            Random rng = new Random();

            int n = cards.Count;
            while (n > 1)
            {
                int k = rng.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
                n--;
            }
        }
    }
}

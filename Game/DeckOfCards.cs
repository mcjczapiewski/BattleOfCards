using BattleOfCards.Game;
using ImTools;
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

        public List<Hand> DealingCards(List<Card> cards, int numberOfPlayers)
        {
            List<Hand> playersHands = new List<Hand>();

            for (int i = 0; i < numberOfPlayers; i++)
            {
                Hand playerHand = new Hand();
                for (int j = 0; j < cards.Count / numberOfPlayers; j++)
                {
                    playerHand.AddSingleCard(cards[0]);
                    cards.RemoveAt(0);
                }

                playersHands.Add(playerHand);
            }

            return playersHands;
        }
    }
}

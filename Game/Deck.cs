using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleOfCards.Game
{
    class Deck
    {
        public List<Card> DeckOfCards = new List<Card>();

        public Deck(List<Card> deckOfCards)
        {
            DeckOfCards = deckOfCards;
        }

        public void Shuffle(List<Card> deckToShuffle)
        {
            //Shuffle using Fisher-Yates Modern method ---> select random number, swap with last number then add to collection.
            Random randomCard = new Random(DateTime.Now.Millisecond);
            for (int n = deckToShuffle.Count - 1; n > 0; --n)
            {
                int randomedCard = randomCard.Next(n + 1);

                Card temporaryDeckCard = deckToShuffle[n];
                deckToShuffle[n] = deckToShuffle[randomedCard];
                deckToShuffle[randomedCard] = temporaryDeckCard;
            }
        }

        public void Dealing()
        {
            while (DeckOfCards.Count() > 0)
            {
                foreach (var Player in Table.Players)
                {
                    if (DeckOfCards.Count() > 0)
                    {
                        Player.HandOfCards.Add(DeckOfCards[0]);
                        DeckOfCards.RemoveAt(0);
                    }
                }
            }
        }
    }
}

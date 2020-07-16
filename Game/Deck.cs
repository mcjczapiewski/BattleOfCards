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
            for (int i = 0; i < Table.Players.Count() && DeckOfCards.Count() != 0; i++)
            {
                Table.Players[i].HandOfCards.Add(DeckOfCards[0]);
                DeckOfCards.RemoveAt(0);
                if (i == Table.Players.Count() - 1)
                {
                    i = -1;
                }
            }
        }

        //public IEnumerable<List<Card>> Dealing(int numberOfPlayers)
        //{
        //    for (int i = 0; i < this.DeckOfCards.Count(); i += numberOfPlayers)
        //    {
        //        yield return this.DeckOfCards.GetRange(i, Math.Min(numberOfPlayers, this.DeckOfCards.Count - i));
        //    }
        //}


    }
}

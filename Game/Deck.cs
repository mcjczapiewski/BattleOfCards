using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleOfCards.Game
{
    class Deck
    {
        private List<Card> DeckOfCards = new List<Card>();

        public void Dealing()
        {
            throw new NotImplementedException();
        }

        private static List<Card> Shuffle(List<Card> DeckOfCards)
        {
            //Shuffle using Fisher-Yates Modern method ---> select random number, swap with last number then add to collection.
            Random randomCard = new Random(DateTime.Now.Millisecond);
            for (int n = DeckOfCards.Count - 1; n > 0; --n)
            {
                int randomedCard = randomCard.Next(n + 1);

                Card temporaryDeckCard = DeckOfCards[n];
                DeckOfCards[n] = DeckOfCards[randomedCard];
                DeckOfCards[randomedCard] = temporaryDeckCard;
            }
            List<Card> ShuffledDeck = new List<Card>();
            foreach (var card in DeckOfCards)
            {
                ShuffledDeck.Add(card);
            }
            return ShuffledDeck;
        }
        
    }
}

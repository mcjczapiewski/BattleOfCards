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

        public void Shuffle()
        {
            //Shuffle using Fisher-Yates Modern method ---> select random number, swap with last number then add to collection.
            Random randomCard = new Random(DateTime.Now.Millisecond);
            for (int n = this.DeckOfCards.Count - 1; n > 0; --n)
            {
                int randomedCard = randomCard.Next(n + 1);

                Card temporaryDeckCard = this.DeckOfCards[n];
                this.DeckOfCards[n] = this.DeckOfCards[randomedCard];
                this.DeckOfCards[randomedCard] = temporaryDeckCard;
            }
        }
        public IEnumerable<List<Card>> Dealing(List<Card> ShuffledDeck, int numberOfPlayers)
        {
            for (int i = 0; i < ShuffledDeck.Count(); i += numberOfPlayers)
            {
                yield return ShuffledDeck.GetRange(i, Math.Min(numberOfPlayers, ShuffledDeck.Count - i));
            }
        }

    }
}

using System.Collections.Generic;

namespace BattleOfCards.Game
{
    class Hand
    {
        private List<Card> playerHand;

        public Hand(List<Card> playerHand)
        {
            PlayerHand = playerHand;
        }

        public List<Card> PlayerHand { get => this.playerHand;  private set => this.playerHand = value; }


        public void RemoveCard()
        {
             playerHand.RemoveAt(0);
        }

        public void AddCard(Card card)
        {
            PlayerHand.Add(card);
        }

        public void AddCard(List<Card> cards)
        {
            PlayerHand.AddRange(cards);
        }
    }
}

using System.Collections.Generic;

namespace BattleOfCards.Game
{
    public class Hand
    {
        private List<Card> playerHand;

        public Hand()
        {
        }

        public List<Card> PlayerHand { get => this.playerHand;  private set => this.playerHand = value; }


        public void RemoveCard()
        {
             playerHand.RemoveAt(0);
        }

        public void AddSingleCard(Card card)
        {
            PlayerHand.Add(card);
        }

        public void AddCards(List<Card> cards)
        {
            PlayerHand.AddRange(cards);
        }
    }
}

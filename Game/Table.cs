using BattleOfCards.Input;
using BattleOfCards.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleOfCards.Game
{
    class Table
    {
        public static List<Player> Players = new List<Player>();
        public static Dictionary<string, int> CardsToCompare = new Dictionary<string, int>();
        private static bool stringOutput = false;
        private static bool intOutput = true;

        static ICardRepo repo = new CardRepo();

        public Deck deck = new Deck(repo.GetAllCards());
        public int PlayerToStart;

        public Table()
        {
        }

        public void GameStart()
        {
            int numberOfPlayers = (int)UserInputs.GetUserInput(
                "What is the number of players?",
                intOutput);
            Player.CreatePlayers(numberOfPlayers);

            deck.Shuffle(deck.DeckOfCards);
            // dealing
            deck.Dealing();
            // random who starts
            Random random = new Random();
            PlayerToStart = random.Next(numberOfPlayers);
            // do 
            PlayRound();
            // while !WinRound
        }

        

        public void PlayRound()
        {

            // pick from player
            var pickedAttribute = Players[PlayerToStart].ChooseAttribute(Players[PlayerToStart].HandOfCards[0]);
            CompareCards(pickedAttribute);
            // compare to cards from other players
            // is there a tie
            // highest value wins
            // add to the end of player's list
        }

        public void CompareCards(int pickedAttribute)
        {
            foreach (Player player in Players)
            {
                switch (pickedAttribute)
                {
                    case 1:
                        CardsToCompare.Add(player.Name, player.HandOfCards[0].Attribute1);
                        break;
                    case 2:
                        CardsToCompare.Add(player.Name, player.HandOfCards[0].Attribute2);
                        break;
                    case 3:
                        CardsToCompare.Add(player.Name, player.HandOfCards[0].Attribute3);
                        break;
                    default:
                        break;
                }
            }
            string result = CardsToCompare.Max(kvp => kvp.Key);
            TransferCardsToWinner(result);
        }

        private void TransferCardsToWinner(string result)
        {
            List<Card> cardsToTransfer = new List<Card>();
            foreach (Player player in Players)
            {
                cardsToTransfer.Add(player.HandOfCards[0]);
                player.HandOfCards.RemoveAt(0);
            }
            deck.Shuffle(cardsToTransfer);
            foreach (Card card in cardsToTransfer)
            {
                Players.Find(p => p.Name.Equals(result)).HandOfCards.Add(card);
            }
            cardsToTransfer.Clear();
        }

        public static bool Tie()
        {
            // check all cards from dictionary if selected attribute has the same value
            throw new NotImplementedException();
        }

        public static bool WinGame()
        {
            if (Players.Any(player => player.HandOfCards.Count == 32))
            {
                return true;
            }
            return false;
        }
    }
}

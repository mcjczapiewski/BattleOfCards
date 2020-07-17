using BattleOfCards.Input;
using BattleOfCards.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BattleOfCards.Game
{
    internal class Table
    {
        public static Dictionary<string, int> CardsToCompare = new Dictionary<string, int>();
        public static List<Card> ItWasTieDeck = new List<Card>();
        public static List<Player> Players = new List<Player>();
        public Deck deck = new Deck(repo.GetAllCards());
        public int PlayerToStart;
        private static bool intOutput = true;

        private static ICardRepo repo = new CardRepo();

        public Table()
        {
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

            List<Card> cardsToTransfer = new List<Card>();
            foreach (Player player in Players)
            {
                cardsToTransfer.Add(player.HandOfCards[0]);
                player.HandOfCards.RemoveAt(0);
            }

            bool doWeHaveAWinner = TieOrWin();
            string result = null;
            if (doWeHaveAWinner)
            {
                int findThisValue = CardsToCompare.Max(kvp => kvp.Value);
                result = CardsToCompare.Where(val => val.Value == findThisValue).Select(key => key.Key).FirstOrDefault();
                TransferCardsToWinner(result, cardsToTransfer);
                PlayerToStart = Players.FindIndex(p => p.Name.Equals(result));
            }
            else
            {
                Console.WriteLine("Bummer, we have tie in this round.");
                ItWasTieDeck.AddRange(cardsToTransfer);
            }
            cardsToTransfer.Clear();
            CardsToCompare.Clear();
        }

        public bool EndGame()
        {
            if (Players.Any(player => player.HandOfCards.Count == 0))
            {
                return true;
            }
            return false;
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
            do
            {
                foreach (Player player in Players)
                {
                    Console.WriteLine($"{player.Name} has {player.HandOfCards.Count()} cards.");
                }
                var pickedAttribute = Players[PlayerToStart].ChooseAttribute(Players[PlayerToStart].HandOfCards[0]);
                CompareCards(pickedAttribute);
            } while (!EndGame());
            Player winner = Players[0];
            Player looser = null;
            foreach (Player player in Players)
            {
                if (player.HandOfCards.Count() == 0)
                {
                    looser = player;
                    continue;
                }
                if (player.HandOfCards.Count() > winner.HandOfCards.Count())
                {
                    winner = player;
                }
            }
            Console.WriteLine($"{winner.Name} wins this game!\n" +
                $"{looser.Name} has 0 cards.");
        }

        public bool TieOrWin()
        {
            var thisIsTie = CardsToCompare
                .GroupBy(z => z.Value)
                .Where(z => z.Count() > 1)
                .ToList();
            if (thisIsTie.Count() != 0)
            {
                return false;
            }
            return true;
        }

        private void TransferCardsToWinner(string result, List<Card> cardsToTransfer)
        {
            if (ItWasTieDeck.Count() > 0)
            {
                cardsToTransfer.AddRange(ItWasTieDeck);
                ItWasTieDeck.Clear();
            }
            deck.Shuffle(cardsToTransfer);
            foreach (Card card in cardsToTransfer)
            {
                Players.Find(p => p.Name.Equals(result)).HandOfCards.Add(card);
            }
        }
    }
}
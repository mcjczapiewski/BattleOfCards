using BattleOfCards.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleOfCards.Game
{
    class Table
    {
        public static List<Player> Players;
        private static Dictionary<string, int> cardsToCompare ;
        private static bool stringOutput = false;
        private static bool intOutput = true;

        public static void GameStart()
        {
            int numberOfPlayers = (int)UserInputs.GetUserInput(
                "What is the number of players?",
                intOutput);
            for (int i = 0; i < numberOfPlayers; i++)
            {
                string playerName = (string)UserInputs.GetUserInput(
                    $"Set name for player no {i + 1}",
                    stringOutput);
                Player player = new Player(playerName);
                Players.Add(player);
            }

            // shuffle
            // dealing
            // random who starts
            // do 
            // PlayRound
            // while !WinRound
        }

        

        public static void PlayRound()
        {
            foreach (Player player in Players)
            {

            }
            // pick from player
            // compare to cards from other players
            // is there a tie
            // highest value wins
            // add to the end of player's list
        }

        public static Player CompareCards()
        {
            cardsToCompare.Add("one", 1);
            cardsToCompare.Add("two", 2);
            cardsToCompare.Add("three", 3);
            string result = cardsToCompare.Max(kvp => kvp.Key);
            Console.WriteLine(result);
            Console.ReadKey();
            return Player;
        }

        public static bool Tie()
        {
            // check all cards from dictionary if selected attribute has the same value
            throw new NotImplementedException();
        }

        public static bool WinRound()
        {
            // check if player took all cards possible
            throw new NotImplementedException();
        }
    }
}

using BattleOfCards.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleOfCards.Game
{
    class Table
    {
        public List<Player> Players;
        private static Dictionary<string, int> cardsToCompare ;

        //public static string userInput { get; private set; }

        public static void GameStart()
        {
            int userInput = (int)UserInputs.GetUserInput("What is the number of players?",
                                                         true);
            for (int i = 0; i < userInput; i++)
            {

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

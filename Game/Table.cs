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

        public static void PlayRound()
        {

        }

        public static void CompareCards()
        {
            cardsToCompare.Add("one", 1);
            cardsToCompare.Add("two", 2);
            cardsToCompare.Add("three", 3);
            string result = cardsToCompare.Max(kvp => kvp.Key);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static void Tie()
        {

        }

        public static void WinRound()
        {

        }
    }
}

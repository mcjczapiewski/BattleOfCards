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
        private static Dictionary<string, int> cardsToCompare ;
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

            deck.Shuffle();
            // dealing
            deck.Dealing();
            // random who starts
            Random random = new Random();
            PlayerToStart = random.Next(numberOfPlayers);
            // do 
            // PlayRound
            // while !WinRound
        }

        

        public void PlayRound()
        {

            // pick from player
            var choosenAttribute = Players[PlayerToStart].ChooseAtribute(Players[PlayerToStart].HandOfCards[0]);
            
            // compare to cards from other players
            // is there a tie
            // highest value wins
            // add to the end of player's list
        }

        //public static Player CompareCards()
        //{
        //    cardsToCompare.Add("one", 1);
        //    cardsToCompare.Add("two", 2);
        //    cardsToCompare.Add("three", 3);
        //    string result = cardsToCompare.Max(kvp => kvp.Key);
        //    Console.WriteLine(result);
        //    Console.ReadKey();
        //    return Player;
        //}

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

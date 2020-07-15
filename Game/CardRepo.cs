using BattleOfCards.Interfaces;
using BattleOfCards.Game;
using System;
using System.Collections.Generic;
using System.IO;

namespace BattleOfCards.Game
{
    public class CardRepo : ICardRepo
    {
        private string fileName = "cards.txt";

        public List<Card> GetAllCards()
        {
            List<Card> cards = new List<Card>();

            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] s = line.Split(",");

                    Card card = new Card(s[0], Convert.ToInt32(s[1]), Convert.ToInt32(s[2]), Convert.ToInt32(s[3]));

                    cards.Add(card);
                }
            }

            return cards;
        }
    }
}

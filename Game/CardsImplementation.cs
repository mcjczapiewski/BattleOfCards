using BattleOfCards.Interfaces;
using BattleOfCards.Game;
using System;
using System.Collections.Generic;
using System.IO;

namespace BattleOfCards.Game
{
    public class CardsImplementation : ICards
    {
        private List<Card> deckOfCards;

        public List<Card> DeckOfCards { get => deckOfCards; private set => deckOfCards = value; }

        public List<Card> GetAllCards(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                
                while ((line = sr.ReadLine()) != null)
                {
                    string[] s = line.Split(",");

                    string name = s[0];
                    int atribute1 = Convert.ToInt32(s[1]);
                    int atribute2 = Convert.ToInt32(s[2]);
                    int atribute3 = Convert.ToInt32(s[3]);

                    Card card = new Card(name, atribute1, atribute2, atribute3)
                    {
                    };

                    DeckOfCards.Add(card);
                }
            }

            return DeckOfCards;
        }
    }
}

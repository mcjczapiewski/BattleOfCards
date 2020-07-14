using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BattleOfCards.Game;
using BattleOfCards.Interfaces;
using BattleOfCards.Output;
using ImTools;

namespace BattleOfCards
{
    class Program
    {
        public static void Main()
        {
            ICardRepo repo = new CardRepo();

            Deck deck = new Deck(repo.GetAllCards());

        }
    } 
}
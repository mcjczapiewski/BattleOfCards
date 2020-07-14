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

            DeckOfCards deck = new DeckOfCards(repo.GetAllCards());

            Player player1 = new Player("Rob", deck.DealingCards(deck.Cards, 4)[0]);
            Player player2 = new Player("Bob", deck.DealingCards(deck.Cards, 4)[1]);
            Player player3 = new Player("Joe", deck.DealingCards(deck.Cards, 4)[2]);
            Player player4 = new Player("Jon", deck.DealingCards(deck.Cards, 4)[3]);
        }
    } 
}
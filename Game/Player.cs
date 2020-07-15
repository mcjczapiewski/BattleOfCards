using BattleOfCards.Input;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BattleOfCards.Game
{
    public class Player
    {
        //public List<Card> handOfCards;

        public string Name { get; set; }
        public List<Card> HandOfCards = new List<Card>();

        public Player(string name)
        {
            Name = name;
        }

        public static void CreatePlayers(int numberOfPlayers)
        {
            bool stringOutput = false;
            for (int i = 0; i < numberOfPlayers; i++)
            {
                string playerName = (string)UserInputs.GetUserInput(
                    $"Set name for player no {i + 1}",
                    stringOutput);
                Player player = new Player(playerName);
                Table.Players.Add(player);
            }
        }

        public int ChooseAtribute(Card card)
        {
            bool intOutput = true;
            Console.WriteLine("You start this round, here's your current card.");
            Console.WriteLine($"Name: {card.Name}\n" +
                $"Att1: {card.Atribute1}\n" +
                $"Att2: {card.Atribute2}\n" +
                $"Att3: {card.Atribute3}\n");
            return (int)UserInputs.GetUserInput(
                "Pick an attribute to fight with.",
                intOutput);
            
        }

        public Card PlayCard()
        {
            Card cardToPlay = this. HandOfCards[0];
            HandOfCards.RemoveAt(0);

            return cardToPlay;
        }
    }
}

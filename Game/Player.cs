using BattleOfCards.Input;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public int ChooseAttribute(Card card)
        {
            bool intOutput = true;
            int pickedAttribute;
            Console.WriteLine($"{this.Name} start this round, here's your current card.");
            Console.WriteLine($"Name: {card.Name}\n" +
                $"  (1)  Att1: {card.Attribute1}\n" +
                $"  (2)  Att2: {card.Attribute2}\n" +
                $"  (3)  Att3: {card.Attribute3}\n");
            do
            {
                pickedAttribute = (int)UserInputs.GetUserInput(
                "Pick an attribute to fight with.",
                intOutput);
            } while (!new[] { 1, 2, 3 }.Contains(pickedAttribute));

            return pickedAttribute;
        }

        public Card PlayCard()
        {
            Card cardToPlay = this. HandOfCards[0];
            HandOfCards.RemoveAt(0);

            return cardToPlay;
        }
    }
}

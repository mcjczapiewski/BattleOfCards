using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards.Output
{
    class PrintOutput
    {
        public static void PrintMenu()
        {
            Console.WriteLine("Welcome to Battle of Cards!");
            Console.WriteLine("Please select what you want to play:");
            Console.WriteLine("1) Player vs player.");
            Console.WriteLine("2) Player vs AI.");
            Console.WriteLine("3) Exit.");
        }
    }
}

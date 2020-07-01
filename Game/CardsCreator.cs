
using ImTools;
using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards.Game
{
    public class CardsCreator
    {
        public void Main()
        {
            Random rnd = new Random();

            for (int i = 1; i < 33; i++)
            {
                string[] line = new string[4];

                string name = $"Card{i}";

                string atribute1 = rnd.Next(1, 6).ToString();
                string atribute2 = rnd.Next(1, 6).ToString();
                string atribute3 = rnd.Next(1, 6).ToString();

                line.Append(name).Append(atribute1).Append(atribute2).Append(atribute3);


            }
        }


    }
}


using ImTools;
using System;
using System.IO;

namespace BattleOfCards.Game
{
    public class CardsCreator
    {
        public void Main()
        {
            Random rnd = new Random();

            string fileName = "cards.txt";
            string currentDirectory = Directory.GetCurrentDirectory();

            FileInfo cards = new FileInfo(currentDirectory + "\\" + fileName);

            if (!cards.Exists)
            {
                cards.Delete();
                cards.Create().Close();
            }
            else
            {
                cards.Create().Close();
            }

            using (StreamWriter sw = cards.AppendText())
            {

                for (int i = 1; i < 33; i++)
                {
                    string[] line = new string[4];

                    string name = $"Card{i}";

                    line[0] = name;

                    int atribute1 = rnd.Next(1, 6);
                    line[1] = atribute1.ToString();

                    int atribute2 = rnd.Next(1, 6);
                    line[2] = atribute2.ToString();

                    int atribute3 = rnd.Next(1, 6);
                    line[3] = atribute3.ToString();



                    sw.Write($"{line[0]}, {line[1]}, {line[2]}, {line[3]}\n");

                }
            }

            Console.WriteLine("The end");
        }
    }
}

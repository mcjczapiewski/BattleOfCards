using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace BattleOfCards.Input
{
    class UserInputs
    {
        public static object GetUserInput(string message, bool integer)
        {
            string userInput;
            bool success = false;
            do
            {
                Console.WriteLine(message);
                Console.Write("> ");
                userInput = Console.ReadLine();
                if (integer)
                {
                    success = Int32.TryParse(userInput, out int intInput);
                    if (success)
                    {
                        return intInput;
                    }
                    else
                    {

                        Console.WriteLine("This answer should be an integer." +
                            "Please, try again.");
                        continue;
                    }
                }
                return userInput;
            } while (!success);

            throw new ArgumentNullException();
        }
    }
}

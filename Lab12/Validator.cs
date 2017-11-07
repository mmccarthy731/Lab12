using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Validator
    {
        public static int GetOpponent(string prompt)
        {
            int opponent = 0;
            bool valid = false;
            while (!valid)
            {
                Console.Write(prompt);
                string input = Console.ReadLine().ToLower();
                if (input == "a")
                {
                    opponent = 0;
                    valid = true;
                }
                else if (input == "b")
                {
                    opponent = 1;
                    valid = true;
                }
                else
                {
                    Console.WriteLine("\nInvalid input.");
                    valid = false;
                }
            }
            return opponent;
        }

        public static Roshambo ValidateUserChoice(string prompt)
        {
            Roshambo pick = (Roshambo)2;
            bool valid = false;
            while (!valid)
            {
                Console.Write(prompt);
                string input = Console.ReadLine().ToLower();

                if (input == "r")
                {
                    pick = Roshambo.rock;
                    valid = true;
                }
                else if(input == "p")
                {
                    pick = Roshambo.paper;
                    valid = true;
                }
                else if(input == "s")
                {
                    pick = Roshambo.scissors;
                    valid = true;
                }
                else
                {
                    Console.WriteLine("\nInvalid input. ");
                    valid = false;
                }
            }
            return pick;

        }

        public static bool DoAgain(string prompt)
        {
            bool repeat = false;
            bool isValid = false;
            while (!isValid)
            {
                Console.Write(prompt);
                string input = Console.ReadLine().ToLower();
                if (input == "y" || input == "yes")
                {
                    isValid = true;
                    repeat = true;
                }
                else if (input == "n" || input == "no")
                {
                    isValid = true;
                    repeat = false;
                }
                else
                {
                    Console.Write("\nInvalid entry. ");
                    isValid = false;
                }
            }
            return repeat;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class User : Player
    {
        
        public User(string name)
            : base(name) { }

        public override Roshambo GenerateRoshambo()
        {
            Roshambo pick = Validator.ValidateUserChoice("\nWhat would you like to throw? (\"R\" for rock, \"P\" for paper, \"S\" for scissors): ");
            return pick;
        }

        public static string GetUserName(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}

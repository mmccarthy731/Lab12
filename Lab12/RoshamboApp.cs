using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RoshamboApp
    {

        static int wins = 0;
        static int losses = 0;
        static int ties = 0;

        static void Main(string[] args)
        {
            List<Player> opponents = new List<Player>();
            opponents.Add(new Opponent1("Rocky Balboa"));
            opponents.Add(new Opponent2("Roshambo Jackson"));

            Console.WriteLine("Let's play Rock, Paper, Scissors!\n");
            string name = User.GetUserName("Please enter your name: ");
            User user = new User(name);

            int index = Validator.GetOpponent("\nPlease select your opponent. (Enter \"A\" to play against Rocky Balboa or \"B\" to play against Roshambo Jackson): ");

            
            bool repeat = true;
            while (repeat)
            { 
                Roshambo pick = user.GenerateRoshambo();
                user.Pick = pick;
                if (opponents[index] is Opponent1)
                {
                    Roshambo opponentPick = ((Opponent1)opponents[index]).GenerateRoshambo();
                    (opponents[index]).Pick = opponentPick;
                    string result = GetResults(user, opponents[index], user.Pick, (opponents[index]).Pick);
                    Console.WriteLine("\n" + user.ToString() + opponents[index].ToString() + result + "\n");
                }
                else
                {
                    Roshambo opponentPick = ((Opponent2)opponents[index]).GenerateRoshambo();
                    (opponents[index]).Pick = opponentPick;
                    string result = GetResults(user, opponents[index], user.Pick, (opponents[index]).Pick);
                    Console.WriteLine("\n" + user.ToString() + opponents[index].ToString() + result + "\n");
                }
                Console.WriteLine($"Record vs. {opponents[index].Name}: {wins}-{losses}-{ties}\n");
                repeat = Validator.DoAgain("Would you like to play again? (Y or N): ");
            }
            Console.WriteLine("\nThank you for playing!\n\nGoodbye.");
            Console.ReadLine();
        }

        public static string GetResults(Player user, Player opponent, Roshambo pick, Roshambo opponentPick)
        {
            string result = "";
            if(pick == Roshambo.rock)
            {
                if(opponentPick == Roshambo.rock)
                {
                    ties++;
                    result = "Draw!";
                }
                else if(opponentPick == Roshambo.paper)
                {
                    losses++;
                    result = $"{opponent.Name} wins!";
                }
                else
                {
                    wins++;
                    result = $"{user.Name} wins!";
                }
            }
            else if(pick == Roshambo.paper)
            {
                if(opponentPick == Roshambo.rock)
                {
                    wins++;
                    result = $"{user.Name} wins!";
                }
                else if(opponentPick == Roshambo.paper)
                {
                    ties++;
                    result = "Draw!";
                }
                else
                {
                    losses++;
                    result = $"{opponent.Name} wins!";
                }
            }
            else
            {
                if(opponentPick == Roshambo.rock)
                {
                    losses++;
                    result = $"{opponent.Name} wins!";
                }
                else if(opponentPick == Roshambo.paper)
                {
                    wins++;
                    result = $"{user.Name} wins!";
                }
                else
                {
                    ties++;
                    result = "Draw!";
                }
            }
            return result;
        }
    }
}

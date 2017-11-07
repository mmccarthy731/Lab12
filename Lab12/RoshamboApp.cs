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
        static void Main(string[] args)
        {
            List<Player> opponents = new List<Player>();
            opponents.Add(new Opponent1("Rocky Balboa"));
            opponents.Add(new Opponent2("Roshambo Jackson"));

            Console.WriteLine("Let's play Rock, Paper, Scissors!\n");
            string name = User.GetUserName("Please enter your name: ");
            User user = new User(name);

            int index = Validator.GetOpponent("\nPlease select your opponent. (Enter \"A\" to play against Rocky Balboa or \"B\" to play against Roshambo Jackson): ");

            int wins = 0;
            int losses = 0;
            int ties = 0;
            
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
                    if (result.Contains(user.Name))
                    {
                        wins++;
                    }
                    else if (result.Contains(opponents[index].Name))
                    {
                        losses++;
                    }
                    else
                    {
                        ties++;
                    }
                }
                else
                {
                    Roshambo opponentPick = ((Opponent2)opponents[index]).GenerateRoshambo();
                    (opponents[index]).Pick = opponentPick;
                    string result = GetResults(user, opponents[index], user.Pick, (opponents[index]).Pick);
                    Console.WriteLine("\n" + user.ToString() + opponents[index].ToString() + result + "\n");
                    if (result.Contains(user.Name))
                    {
                        wins++;
                    }
                    else if (result.Contains(opponents[index].Name))
                    {
                        losses++;
                    }
                    else
                    {
                        ties++;
                    }
                }
                Console.WriteLine($"Record vs. {opponents[index].Name}: {wins}-{losses}-{ties}\n");
                repeat = Validator.DoAgain("Would you like to play again? (Y or N): ");
            }
            Console.WriteLine("Thank you for playing! Goodbye.");
            Console.ReadLine();
        }

        public static string GetResults(Player user, Player opponent, Roshambo pick, Roshambo opponentPick)
        {
            string result = "";
            if(pick == Roshambo.rock)
            {
                if(opponentPick == Roshambo.rock)
                {
                    result = "Draw!";
                }
                else if(opponentPick == Roshambo.paper)
                {
                    result = $"{opponent.Name} wins!";
                }
                else
                {
                    result = $"{user.Name} wins!";
                }
            }
            else if(pick == Roshambo.paper)
            {
                if(opponentPick == Roshambo.rock)
                {
                    result = $"{user.Name} wins!";
                }
                else if(opponentPick == Roshambo.paper)
                {
                    result = "Draw!";
                }
                else
                {
                    result = $"{opponent.Name} wins!";
                }
            }
            else
            {
                if(opponentPick == Roshambo.rock)
                {
                    result = $"{opponent.Name} wins!";
                }
                else if(opponentPick == Roshambo.paper)
                {
                    result = $"{user.Name} wins!";
                }
                else
                {
                    result = "Draw!";
                }
            }
            return result;
        }
    }
}

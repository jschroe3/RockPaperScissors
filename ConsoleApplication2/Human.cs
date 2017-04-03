using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Human : Player
    {
        public Human()
        {

        }
        public override void GetPlayerName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }
        public override string GetPlayerChoice()
        {
            Console.WriteLine("Please type in your move, 'rock', 'paper', 'scissors', 'lizard', 'spock'.");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "rock":
                    Console.WriteLine("");
                    break;
                case "paper":
                    Console.WriteLine("");
                    break;
                case "scissors":
                    Console.WriteLine("");
                    break;
                case "lizard":
                    Console.WriteLine("");
                    break;
                case "spock":
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("That doesnt seem to be an option");
                    break;
            }
            return choice;
        }
    }
}

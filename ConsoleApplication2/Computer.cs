using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
    {
        public class Computer : Player
        {
            public override void GetPlayerName()
            {
                Console.WriteLine("You are playing against Illidan");
                Console.ReadLine();
                name = "Illidan";
            }
            public override string GetPlayerChoice()
            {
                Random halChoice = new Random();
                int choice = halChoice.Next(1, 6);

                switch (choice)
                {
                    case 1:
                        this.choice = "rock";
                        Console.WriteLine("Illidan chose rock");
                        Console.ReadLine();
                        break;
                    case 2:
                        this.choice = "paper";
                        Console.WriteLine("Illidan chose paper");
                        Console.ReadLine();
                        break;
                    case 3:
                        this.choice = "scissors";
                        Console.WriteLine("Illidan chose scissors");
                        Console.ReadLine();
                        break;
                    case 4:
                        this.choice = "lizard";
                        Console.WriteLine("Illidan chose lizzard");
                        Console.ReadLine();
                        break;
                    case 5:
                        this.choice = "spock";
                        Console.WriteLine("Illidan chose spock");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("O No");
                        break;
                }
                return null;
            }
        }
    }
   

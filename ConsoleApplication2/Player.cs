using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public abstract class Player
    {
        public string name;
        public string choice;
        public int score;

        public Player()
        {

        }
        public virtual void GetPlayerName()
        {
            Console.WriteLine("What are you refered to as?");
            name = Console.ReadLine();
        }
        public abstract string GetPlayerChoice();
    }
}

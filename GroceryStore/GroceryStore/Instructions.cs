using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore
{
    class Instructions
    {
        Time time = new Time();
       
        public void startinstructions()
        {
            Options options = new Options();

            Console.WriteLine("You start with $500. You have to buy crops or else you will have a No Sale Day. which means you will have no income that day,");
            Console.WriteLine(" wasting time and not being able to beat the high scores. the goal is to make ");
            Console.WriteLine(" alot of money as fast as possible. time is ticking once you start.");
            Console.WriteLine("the more applications you hire the more money you make!");
            Console.WriteLine("you get 10 days !");

            time.FiveSec();
            options.start();
        }
    }
}

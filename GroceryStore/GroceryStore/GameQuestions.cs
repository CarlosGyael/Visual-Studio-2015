using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore
{
    class GameQuestions
    {
        string line;
        bool res;
        int choice;

      public void outofstock()
        {
            Console.WriteLine("you dont have enough money or item amount is out of stock!");
        }

        public int input()
        {
            line = Console.ReadLine();

            res = int.TryParse(line, out choice);
            if (res == false)
            {
                Console.WriteLine("{0} is not an integer", line);

            }

            return choice;
        }

        public void givecropname() {
            
            Console.Write(" value is now high due to the news");
            Console.Write("how much do you want to buy?                                                               my money: $");
        }

        public void yesno() {
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
        }
    }
}

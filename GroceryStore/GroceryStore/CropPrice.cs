using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore
{
    class CropOptions
    {
        public void normal()
        {
            Console.WriteLine("1. $100 = 50 pieces");
            Console.WriteLine("2. $150 = 100 pieces");
            Console.WriteLine("3. $250 = 200 pieces");
            Console.WriteLine("4. $450 = 400 pieces");
            Console.WriteLine("5. $550 = 500 pieces");

        }
        public void valueable()
        {
            Console.WriteLine("1. $200 = 50 pieces");
            Console.WriteLine("2. $400 = 100 pieces");
            Console.WriteLine("3. $700 = 200 pieces");
            Console.WriteLine("4. $900 = 400 pieces");
            Console.WriteLine("5. $1000 = 500 pieces");
        }
         }
}

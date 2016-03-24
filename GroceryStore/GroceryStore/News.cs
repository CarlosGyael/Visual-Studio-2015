using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore
{
    class News
    {
        Time time = new Time();


        public int keepnum;



        public int news(int anynum)
        {


            if (anynum == 1)
            {
                Console.WriteLine("corn farms are now being burned down! new corn viruse discovered!");
                keepnum = 1;

            }
            else if (anynum == 2)
            {
                Console.WriteLine("potatoe farms are now being whipped out! new potatoe insect discovered!");
                keepnum = 2;
            }
            else if (anynum == 3)
            {
                Console.WriteLine("wheat crops are now being researched! flour may have the cure to cancer!");
                keepnum = 3;
            }
            else if (anynum == 4)
            {
                Console.WriteLine("tomatoes are now fueling cars! tomatoes are now a valuable resource!");
                keepnum = 4;
            }
            else if (anynum == 5)
            {
                Console.WriteLine("cows now produce more milk while eating lettuce! lettuce are now a valuable recource!");
                keepnum = 5;
            }
            else if (anynum == 6)
            {
                Console.WriteLine("beans are now used for jet fuel! beans are now a valuable recource!");
                keepnum = 6;
            }
            else
            {
                Console.WriteLine("cows now produce more milk while eating lettuce! lettuce are now a valuable recource!");
                keepnum = 5;

            }
            return keepnum;

        }


    }
}

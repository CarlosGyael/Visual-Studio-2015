using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore
{
    class Game
    {
        Time time = new Time();
        int choice;

       public int keepnum;
        int test;

       public int news( int anynum)
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
            } else
            {
                Console.WriteLine("cows now produce more milk while eating lettuce! lettuce are now a valuable recource!");
                keepnum = 5;

            }return test;
        }

        public void cornspec() {
            Options options = new Options();

            if (choice == 1)
            {
                options.shoplist[0] -= 50;
                options.Money = options.Money - 200;
                options.Items[0] += 50;
            }
            else if (choice == 2)
            {
                options.shoplist[0] -= 100;
                options.Money = options.Money - 400;
                options.Items[0] += 100;
            }
            else if (choice == 3)
            {
                options.shoplist[0] -= 200;
                options.Money = options.Money - 700;
                options.Items[0] += 200;
            }
            else if (choice == 4)
            {
                options.shoplist[0] -= 400;
                options.Money = options.Money - 900;
                options.Items[0] += 400;
            }
            else if (choice == 5)
            {
                options.shoplist[0] -= 500;
                options.Money = options.Money - 1000;
                options.Items[0] += 500;
            }
        }
        public void potatoespec() {
            Options options = new Options();
            if (choice == 1)
            {
                options.shoplist[1] -= 50;
                options.Money = options.Money - 200;
                options.Items[1] += 50;
            }
            else if (choice == 2)
            {
                options.shoplist[1] -= 100;
                options.Money = options.Money - 400;
                options.Items[1] += 100;
            }
            else if (choice == 3)
            {
                options.shoplist[1] -= 200;
                options.Money = options.Money - 700;
                options.Items[1] += 200;
            }
            else if (choice == 4)
            {
                options.shoplist[1] -= 400;
                options.Money = options.Money - 900;
                options.Items[1] += 400;
            }
            else if (choice == 5)
            {
                options.shoplist[1] -= 500;
                options.Money = options.Money - 1000;
                options.Items[1] += 500;
            }
        }

        public void tomatoesspec() {
            {
                Options options = new Options();
                if(choice == 1) { 
                options.shoplist[3] -= 50;
                options.Money = options.Money - 200;
                options.Items[3] += 50;
            }
                    else if (choice == 2)
            {
                options.shoplist[3] -= 100;
                options.Money = options.Money - 400;
                options.Items[3] += 100;
            }
            else if (choice == 3)
            {
                options.shoplist[3] -= 200;
                options.Money = options.Money - 700;
                options.Items[3] += 200;
            }
            else if (choice == 4)
            {
                options.shoplist[3] -= 400;
                options.Items[3] += 400;
                options.Money = options.Money - 900;
            }
            else if (choice == 5)
            {
                options.shoplist[3] -= 500;
                options.Money = options.Money - 1000;
                options.Items[3] += 500;
            }
        }
 }
            public void specflour() {
            Options options = new Options();
            if (choice == 1)
            {
                options.shoplist[2] -= 50;
                options.Money = options.Money - 200;
                options.Items[2] += 50;
            }
            else if (choice == 2)
            {
                options.shoplist[2] -= 100;
                options.Money = options.Money - 400;
                options.Items[2] += 100;
            }
            else if (choice == 3)
            {
                options.shoplist[2] -= 200;
                options.Money = options.Money - 700;
                options.Items[2] += 200;
            }
            else if (choice == 4)
            {
                options.shoplist[2] -= 400;
                options.Money = options.Money - 900;
                options.Items[2] += 400;
            }
            else if (choice == 5)
            {
                options.shoplist[2] -= 500;
                options.Money = options.Money - 1000;
                options.Items[2] += 50;
            }

        }
        public void lettucespec() {
            Options options = new Options();
            if (choice == 1)
            {
                options.shoplist[4] -= 50;
                options.Money = options.Money - 200;
                options.Items[4] += 50;
            }
            else if (choice == 2)
            {
                options.shoplist[4] -= 100;
                options.Money = options.Money - 400;
                options.Items[4] += 100;
            }
            else if (choice == 3)
            {
                options.shoplist[4] -= 200;
                options.Money = options.Money - 700;
                options.Items[4] += 200;
            }
            else if (choice == 4)
            {
                options.shoplist[4] -= 400;
                options.Money = options.Money - 900;
                options.Items[4] += 400;
            }
            else if (choice == 5)
            {
                options.shoplist[4] -= 500;
                options.Money = options.Money - 1000;
                options.Items[4] += 500;
            }
        }

        public void specbeans() {
            Options options = new Options();
            if (choice == 1)
            {
                options.shoplist[6] -= 50;
                options.Money = options.Money - 200;
                options.Items[6] += 50;
            }
            else if (choice == 2)
            {
                options.shoplist[6] -= 100;
                options.Money = options.Money - 400;
                options.Items[6] += 100;
            }
            else if (choice == 3)
            {
                options.shoplist[6] -= 200;
                options.Money = options.Money - 700;
                options.Items[6] += 200;
            }
            else if (choice == 4)
            {
                options.shoplist[6] -= 400;
                options.Money = options.Money - 900;
                options.Items[6] += 400;
            }
            else if (choice == 5)
            {
                options.shoplist[6] -= 500;
                options.Money = options.Money - 1000;
                options.Items[6] += 500;
            }
        }
   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore
{
    class CropOptions
    {
        int choice;

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
        public void weak()
        {
            Console.WriteLine("1. $10 = 50 pieces");
            Console.WriteLine("2. $50 = 100 pieces");
            Console.WriteLine("3. $150 = 200 pieces");
            Console.WriteLine("4. $350 = 400 pieces");
            Console.WriteLine("5. $450 = 500 pieces");
        }


        public void corn() {
            Options options = new Options();
            if (choice == 1)
            {
                options.shoplist[0] -= 50;
                options.Money = options.Money - 100;
                options.Items[0] += 50;
            }
            else if (choice == 2)
            {
                options.shoplist[0] -= 100;
                options.Money = options.Money - 150;
                options.Items[0] += 100;
            }
            else if (choice == 3)
            {
                options.shoplist[0] -= 200;
                options.Money = options.Money - 250;
                options.Items[0] += 200;
            }
            else if (choice == 4)
            {
                options.shoplist[0] -= 400;
                options.Money = options.Money - 450;
                options.Items[0] += 400;
            }
            else if (choice == 5)
            {
                options.shoplist[0] -= 500;
                options.Money = options.Money - 550;
                options.Items[0] += 500;
            }
        }
        public void potatoe(){
            Options options = new Options();
            if (choice == 1)
            {
                options.shoplist[1] -= 50;
                options.Money = options.Money - 100;
                options.Items[1] += 50;
            }
            else if (choice == 2)
            {
                options.shoplist[1] -= 100;
                options.Money = options.Money - 150;
                options.Items[1] += 100;
            }
            else if (choice == 3)
            {
                options.shoplist[1] -= 200;
                options.Money = options.Money - 250;
                options.Items[1] += 200;
            }
            else if (choice == 4)
            {
                options.shoplist[1] -= 400;
                options.Money = options.Money - 450;
                options.Items[1] += 400;
            }
            else if (choice == 5)
            {
                options.shoplist[1] -= 500;
                options.Money = options.Money - 550;
                options.Items[1] += 500;
            }
        }
        public void flour() {
            Options options = new Options();
            if (choice == 1)
            {
                options.shoplist[2] -= 50;
                options.Money = options.Money - 100;
                options.Items[2] += 50;

            }
            else if (choice == 2)
            {
                options.shoplist[2] -= 100;
                options.Money = options.Money - 150;
                options.Items[2] += 100;
            }
            else if (choice == 3)
            {
                options.shoplist[2] -= 200;
                options.Money = options.Money - 250;
                options.Items[2] += 200;
            }
            else if (choice == 4)
            {
                options.shoplist[2] -= 400;
                options.Money = options.Money - 450;
                options.Items[2] += 400;
            }
            else if (choice == 5)
            {
                options.shoplist[2] -= 500;
                options.Money = options.Money - 550;
                options.Items[2] += 500;
            }
        }
        public void tomatoe() {
            Options options = new Options();
            if (choice == 1)
            {
                options.shoplist[3] -= 50;
                options.Money = options.Money - 100;
                options.Items[3] += 50;
            }
            else if (choice == 2)
            {
                options.shoplist[3] -= 100;
                options.Money = options.Money - 150;
                options.Items[3] += 100;
            }
            else if (choice == 3)
            {
                options.shoplist[3] -= 200;
                options.Money = options.Money - 250;
                options.Items[3] += 200;
            }
            else if (choice == 4)
            {
                options.shoplist[3] -= 400;
                options.Money = options.Money - 450;
                options.Items[3] += 400;
            }
            else if (choice == 5)
            {
                options.shoplist[3] -= 500;
                options.Money = options.Money - 550;
                options.Items[3] += 500;
            }
        }
        public void lettuce() {
            Options options = new Options();
            if (choice == 1)
            {
                options.shoplist[4] -= 50;
                options.Money = options.Money - 100;
                options.Items[4] += 50;
            }
            else if (choice == 2)
            {
                options.shoplist[4] -= 100;
                options.Money = options.Money - 150;
                options.Items[4] += 100;
            }
            else if (choice == 3)
            {
                options.shoplist[4] -= 200;
                options.Money = options.Money - 250;
                options.Items[4] += 200;
            }
            else if (choice == 4)
            {
                options.shoplist[4] -= 400;
                options.Money = options.Money - 450;
                options.Items[4] += 400;
            }
            else if (choice == 5)
            {
                options.shoplist[4] -= 500;
                options.Money = options.Money - 550;
                options.Items[4] += 500;
            }
        }
        public void beans() {
            Options options = new Options();
            if (choice == 1)
            {
                options.shoplist[5] -= 50;
                options.Money = options.Money - 100;
                options.Items[5] += 50;

            }
            else if (choice == 2)
            {
                options.shoplist[5] -= 100;
                options.Money = options.Money - 150;
                options.Items[5] += 100;
            }
            else if (choice == 3)
            {
                options.shoplist[5] -= 200;
                options.Money = options.Money - 250;
                options.Items[5] += 200;
            }
            else if (choice == 4)
            {
                options.shoplist[5] -= 400;
                options.Money = options.Money - 450;
                options.Items[5] += 400;
            }
            else if (choice == 5)
            {
                options.shoplist[5] -= 500;
                options.Money = options.Money - 550;
                options.Items[5] += 500;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore
{
    class RandomeName
    {

        string name;
        RandomInt rand = new RandomInt();
        public string random()
        {
            int num=0;

            num += 1;

            if (num == 1)
            {
                name = "Steve";
            }
            else if (num == 2)
            {
                name = "Wanda";
            }
            else if (num == 3)
            {
                name = "Carlos";
            }
            else if (num == 4)
            {
                name = "Heather";
            }
            else if (num == 5)
            {
                name = "Jim";
            }
            else if (num == 6)
            {
                name = "Fiora";
            }
            else if (num == 7)
            {
                name = "Carol";
            }
            else if (num == 8)
            {
                name = "Justin";
            }
            else if (num == 9)
            {
                name = "Flash";
            }
            else if (num == 10)
            {
                name = "John";
            }
            else { name = "Flash"; }


            return name;
        }

    }
}

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
            int randomnum = rand.Random(10);

            if (randomnum == 1)
            {
                name = "Steve";
            }
            else if (randomnum == 2)
            {
                name = "Wanda";
            }
            else if (randomnum == 3)
            {
                name = "Carlos";
            }
            else if (randomnum == 4)
            {
                name = "Heather";
            }
            else if (randomnum == 5)
            {
                name = "Jim";
            }
            else if (randomnum == 6)
            {
                name = "Fiora";
            }
            else if (randomnum == 7)
            {
                name = "Carol";
            }
            else if (randomnum == 8)
            {
                name = "Justin";
            }
            else if (randomnum == 9)
            {
                name = "Flash";
            }
            else if (randomnum == 10)
            {
                name = "John";
            }
            else { name = "Flash"; }


            return name;
        }

    }
}

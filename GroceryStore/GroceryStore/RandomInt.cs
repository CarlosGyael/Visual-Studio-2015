using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore
{
    class RandomInt
    {
        Random rand = new Random();
        public int Random(int num) {
            num = rand.Next(0, num)+1;
            return num;
        }

        public int normal(int item) {
            item = rand.Next(40, 100);
           
            return item;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureComplexities1
{
    class SortedList
    {

        static public void print()
        {
            List<int> list = new List<int>();//added numbers backwards

            for (int i = 7; i > 0; i--)
            {
                list.Add(i);
            }

            list.Sort();//sorting list

            foreach (int number in list)
            {
                Console.WriteLine(number);
            }
        }
    }
}

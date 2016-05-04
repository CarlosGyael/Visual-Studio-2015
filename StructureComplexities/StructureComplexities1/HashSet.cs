using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureComplexities1
{
    class HashSet
    {
       static public void print()
        {
            HashSet<int> list = new HashSet<int>();
            list.Add(1);
            list.Add(1);

            Console.WriteLine(list.Count);

            list.Add(2);
            list.Remove(1);

            Console.WriteLine(list.Count);

        }
    }
}

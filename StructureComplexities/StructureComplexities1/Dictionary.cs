using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureComplexities1
{
    class Dictionary
    {
        

        static public void print()
        {
            Dictionary<string, int> list = new Dictionary<string, int>();
            list.Add("Monday", 0);
            list.Add("Tuesday", 1);
            list.Add("Wednsday", 2);
            list.Add("Thursday", 3);
            list.Add("Friday", 4);

            list.Remove("Thursday");

            foreach (KeyValuePair<string , int> day in list)
            {
                Console.WriteLine(day);
            }
        }
    }
}

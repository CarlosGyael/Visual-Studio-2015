using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureComplexities1
{
    class List
    {
        static public void print()
        {
            List<string> list = new List<string>();

            list.Add("added");
            Console.WriteLine("list added: " + list[0]);//add string

            list.Insert(0, "hi");
            Console.WriteLine("listchanged to: " + list[0]);//inserted string pushed index 0 to index 1
            
            list.Clear();//empty list
            if (list.Count == 0)
            {
                Console.WriteLine("list is now empty");
            }
        }
    }
}

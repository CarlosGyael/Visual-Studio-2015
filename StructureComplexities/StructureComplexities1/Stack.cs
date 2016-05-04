using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureComplexities1
{
    class Stack
    {

        static public void print()
        {
            Stack<int> list = new Stack<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Push(i);
            }

            list.Pop();
            list.Pop();

            Console.WriteLine(list.Peek());
        }
    }
}

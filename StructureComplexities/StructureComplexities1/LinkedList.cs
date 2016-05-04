using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureComplexities1
{
    class LinkedList
    {
        static public void print()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFirst(1);//add head node
            LinkedListNode<int> node = list.Find(1);//node = head

            list.AddLast(3);
            list.AddLast(4);//added two nodes

            list.AddAfter(node, 2);//inserted 2 after 1

            foreach (int number in list)
            {
                Console.WriteLine(number);
            }
        }
    }
}

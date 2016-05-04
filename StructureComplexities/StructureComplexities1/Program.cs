using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureComplexities1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List___________");
            List.print();
            Console.WriteLine("LinkedList___________");
            LinkedList.print();
            Console.WriteLine("SortedList___________");
            SortedList.print();
            Console.WriteLine("Dictionary___________");
            Dictionary.print();
            Console.WriteLine("HashSet___________");
            HashSet.print();
            Console.WriteLine("Stack___________");
            Stack.print();
            Console.WriteLine("BST___________");
            BinaryTree b = new BinaryTree();
            b.insert(1);
            b.insert(6);
            b.insert(2);
            b.insert(4);
            b.insert(5);
            b.insert(3);

            b.display();

            Console.ReadKey();

        }
    }
}

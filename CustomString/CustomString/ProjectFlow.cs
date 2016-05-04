using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    class ProjectFlow
    {

        public void flow()
        {
            CustomString();
            arrayString();
            LinkedList();
            node();
            sortedList();
            Console.ReadKey();
        }

        public void CustomString()
        {
            SystemString normalstring = new SystemString();
            string name = "Carlos";
            int length = name.Length;
            normalstring.word = name;
            normalstring.Insert(normalstring.word);
            normalstring.Remove(2, 3);
            Console.WriteLine(normalstring.ToString());
        }
        public void arrayString()
        {
            SystemArrayString ArrayString = new SystemArrayString();
            ArrayString.word = "Hi Applebees";
            ArrayString.Length();
            ArrayString.Insert(ArrayString.word);
            ArrayString.Remove(3 , 4);
            ArrayString.ToString();
            Console.WriteLine(ArrayString.newword);
        }
        public void LinkedList()
        {
            SystemLinkedListString linkedList = new SystemLinkedListString();
            linkedList.word = "sup guys";
            linkedList.Length();
            linkedList.Insert(linkedList.word);
            linkedList.Remove(2, 3);
            linkedList.ToString();
            Console.WriteLine(linkedList.newword);
        }

        public void node()
        {
            CustomLinkedListString custom = new CustomLinkedListString();
            custom.word = "Hello";
            custom.Length();
            custom.Insert(custom.word);
            custom.Remove(2, 2);
            custom.ToString();
            Console.WriteLine(custom.newword);
        }
        public void sortedList()
        {
            SortedList sort = new SortedList();
            SortedList sort1 = new SortedList();
            SortedList sort2 = new SortedList();
            SortedList sort3 = new SortedList();
            LinkedList<List<char>> list = new LinkedList<List<char>>();
            sort.Insert("Hello");
            list.AddFirst(sort.ReturnList());
            sort1.Insert("Kelly");
            list.AddFirst(sort1.ReturnList());
            sort2.Insert("Christopher");
            list.AddLast(sort2.ReturnList());
            sort3.Insert("Hi");
            list.AddFirst(sort3.ReturnList());
            foreach (List<char> item in list)
            {
                foreach (char letter in item)
                {
                    Console.Write(letter);
                }
                Console.WriteLine("");
            }
        }

       
    }
}


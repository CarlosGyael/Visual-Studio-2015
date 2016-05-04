using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    class SortedList
    {
        
        List<char> mylist = new List<char>();

        public void Insert(string stringToInsert)
        {

            foreach (char letter in stringToInsert)
            {
                mylist.Add(letter);
            }
        }

        public List<char> ReturnList()
        {
            return mylist;
        }


    }
}

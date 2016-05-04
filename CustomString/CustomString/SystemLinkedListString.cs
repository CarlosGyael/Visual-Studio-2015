using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    class SystemLinkedListString : ICustomString
    {
        public string word;
        public string newword;
        int wordlength;
        char[] myarray;

        LinkedList<char> mylist = new LinkedList<char>();
        public void Insert(string stringToInsert)
        {
            stringToInsert = word;

            myarray = word.ToCharArray();

            for (int i = 0; wordlength > i; i++)
            {
                if (i == 0)
                {
                    mylist.AddFirst(myarray[i]);
                }
                else
                {
                    mylist.AddLast(myarray[i]);
                }
            }
        }

        public int Length()
        {
            wordlength = word.Length;
            return wordlength;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            if (numCharsToRemove > Length())
            {
                Console.WriteLine("word does not have that many Characters");
            }
            else
            {
                int j = 0;
                for (int i = startIndex; j < numCharsToRemove; j++, i++)
                {
                    mylist.Remove(myarray[i]);
                }
                mylist.ToString();
            }
        }
        public override string ToString()
        {
            foreach (char letter in mylist)
            {
                if (letter == '\0')
                {
                    //nothing
                }
                else
                {
                    newword += letter;
                }

            }
            return newword;
        }

    }
}

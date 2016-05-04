using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    class CustomLinkedListString : ICustomString
    {

        public string word;
        public string newword;
        int wordlength;
        char[] myarray;
        List<Node> mylist = new List<Node>();

        public void Insert(string stringToInsert)
        {
            stringToInsert = word;

            myarray = word.ToCharArray();

            for (int i = 0; wordlength > i; i++)
            {
                mylist.Add(new Node(myarray[i]));
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
                for (int i = startIndex; j < numCharsToRemove; j++ )
                {
                    mylist.Remove(mylist[i]);
                }
            }
            mylist.ToString();

        }
        public override string ToString()
        {
            foreach (Node letter in mylist)
            {
                if (letter == null)
                {
                    //nothing
                }
                else
                {
                    newword += letter.Data;
                }

            }
            return newword;
        }

    }
}

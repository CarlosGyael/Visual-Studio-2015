using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    class SystemArrayString : ICustomString
    {
        public string word;
        public string newword;
        int wordlength;
        char[] myarray;

        public void Insert(string stringToInsert)
        {
            stringToInsert = word;

            myarray = word.ToCharArray();
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
                    myarray.SetValue(null, i);
                }
                myarray.ToString();
            }
        }

        public override string ToString()
        {
            foreach (char letter in myarray)
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

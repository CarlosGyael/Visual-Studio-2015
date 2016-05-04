using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    class SystemString : ICustomString
    {
        public int StringLength;

        public string word;
        public string partword;
        public string newword;
        public override string ToString()
        {
            return newword;
        }

        public void Insert(string stringToInsert)
        {
            stringToInsert = word;

        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            Length();
            if (numCharsToRemove > Length())
            {
                Console.WriteLine("word does not have that many Characters");
            }
            else
            {
                partword = word.Substring(0, startIndex);
                startIndex += numCharsToRemove; 
                newword = word.Substring(startIndex, (StringLength-startIndex));
                newword = partword + newword;
            }
            

        }

        public int Length()
        {
            StringLength = word.Length;
            return StringLength;
        }
    }
}

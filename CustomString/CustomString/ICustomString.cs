using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    interface ICustomString
    {
        string ToString();

        void Insert(string stringToInsert);

        void Remove(int startIndex, int numCharsToRemove);

        int Length();
       
    }
}

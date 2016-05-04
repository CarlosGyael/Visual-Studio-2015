using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            SortI sortI = new SortI();
            SortQ sortQ = new SortQ();

            int[] unsortedArray = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            int[] mSortedArray = SortM.Sort(unsortedArray);
            int[] qSortedArray = SortQ.Sort(unsortedArray);
            int[] iSortedArray = SortI.Sort(unsortedArray);

            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Console.Write(mSortedArray[i]);
                Console.Write(qSortedArray[i]);
                Console.Write(iSortedArray[i]);
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class SortI
    {
        static private void Sort(int[] array, int length)
        {
            for (int i = 1; i < length; i++)
            {
                int j = i;
                while (j > 0)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                        j--;
                    }
                    else
                        break;
                }
            }
        }

        static public int[] Sort(int[] unsortedArray)
        {
            int[] sortedArray = new int[unsortedArray.Length];
            Array.Copy(unsortedArray, sortedArray, unsortedArray.Length);
            Sort(sortedArray, unsortedArray.Length);
            return sortedArray;
        }
    }
}
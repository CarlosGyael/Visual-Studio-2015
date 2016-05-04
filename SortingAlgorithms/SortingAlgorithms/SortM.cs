using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class SortM
    {
        public static int[] Recursive(int[] array)
        {
            Recursive(array, 0, array.Length);
            return array;
        }

        private static void Recursive(int[] array, int start, int end)
        {
            if (end - start <= 1) return;
            int middle = start + (end - start) / 2;

            Recursive(array, start, middle);
            Recursive(array, middle, end);
            Merge(array, start, middle, end);
        }

        private static void Merge(int[] array, int start, int middle, int end)
        {
            int[] merge = new int[end - start];
            int left = 0, right = 0, i = 0;
            while (left < middle - start && right < end - middle)
            {
                merge[i++] = array[start + left] < array[middle + right]
                    ? array[start + left++]
                    : array[middle + right++];
            }

            while (right < end - middle)
            {
                merge[i++] = array[middle + right++];
            }

            while (left < middle - start)
            {
                merge[i++] = array[start + left++];
            }

            Array.Copy(merge, 0, array, start, merge.Length);
        }

        static public int[] Sort(int[] numbers)
        {
            int[] returnNumbers = Recursive(numbers);
            
            return returnNumbers;
        }
    }
}
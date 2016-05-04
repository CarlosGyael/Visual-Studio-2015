using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class SortQ
    {
        static private int Partition(int[] array, int left, int right)
        {
            int pivot = array[left];
            while (true)
            {
                while (array[left] < pivot)
                    left++;

                while (array[right] > pivot)
                    right--;

                if (left < right)
                {
                    int temp = array[right];
                    array[right] = array[left];
                    array[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        static private void Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);

                if (pivot > 1)
                    Sort(array, left, pivot - 1);

                if (pivot + 1 < right)
                    Sort(array, pivot + 1, right);
            }
        }

        static public int[] Sort(int[] unsortedArray)
        {
            int[] sortedArray = new int[unsortedArray.Length];
            Array.Copy(unsortedArray, sortedArray, unsortedArray.Length);
            Sort(sortedArray, 0, unsortedArray.Length - 1);
            return sortedArray;
        }
    }
}
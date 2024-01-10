using System;
using System.Collections;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    class SortingAlgorithms
    {
        public static void Main(string[] Args)
        {
            int[] MyArray = { 4, 12, 2, 7, 14, 3, 9, 5, 1, 0 };

            //InsertionSort.Insertion_Sort();
            //SelectionSort.Selection_Sort();
            //BubbleSort.Bubble_Sort(MyArray);
            foreach (int item in SelectionSort.Selection_Sort(MyArray))
            {
                Console.Write(item + ", ");
            }
        }
    }
}
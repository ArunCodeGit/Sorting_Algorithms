using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class InsertionSort
    {
        #region Insertion Sort
        public static int[] Insertion_Sort(int[] MyArray)
        {            
            for (int i = 1; i < MyArray.Length; i++)
            {
                int j;
                int temp = MyArray[i];
                for (j = i - 1; j >= 0 && MyArray[j] > temp; j--)
                {
                    MyArray[j + 1] = MyArray[j];
                }
                MyArray[j + 1] = temp;
            }
            return MyArray;
        }
        #endregion
    }
}

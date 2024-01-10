using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class BubbleSort
    {
        #region Bubble sort to sort the array ascending order.
        public static int[] Bubble_Sort(int[] MyArray)
        {
            for(int i=0;i<MyArray.Length-1;i++)
            {
                for(int j=0; j<MyArray.Length-1; j++)
                {
                    if (MyArray[j] > MyArray[j+1])
                    {
                        int temp = MyArray[j+1];
                        MyArray[j+1] = MyArray[j];
                        MyArray[j] = temp;
                    }
                }
            }
            return MyArray;
        }
        #endregion
    }
}

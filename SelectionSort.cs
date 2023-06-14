using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class SelectionSort
    {
        #region Selection sort to sort the array ascending order.
        public static void Selection_Sort(int[] MyArray)
        {
            for(int i=0;i<MyArray.Length;i++)
            {
                int minIndex = i;
                for(int j=i+1;j<MyArray.Length;j++)
                {
                    if (MyArray[j] < MyArray[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if(i!=minIndex)
                {
                    int temp = MyArray[i];
                    MyArray[i] = MyArray[minIndex];
                    MyArray[minIndex] = temp;
                }
                foreach (int item in MyArray)
                {
                    Console.Write(item + ", ");
                }
                Console.WriteLine();
            }            
            //return MyArray;
        }
        #endregion
    }
}

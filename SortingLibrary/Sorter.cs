using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLibrary
{
    public class Sorter<T> where T : IComparable<T>
    {
        /**
         * If array is empty, return null
         * Iterates through each element of the array
         * Compares current value to the next value
         *      swap values if the next is larger
         * In the event of duplicates, they do not swap
         * If full iteration without swaping it is fully sorted
         * At the end of the first interation the last number is the largest
         * 
         * Pseudo-code:
         * array equals empty, return null
         * forloop all element in the array -1
         *      forloop all elements in the array
         *          if current > currentIndex+1
         *              swap values
         */         
        public static void BubbleSort(T[] arr)
        {
            //n^2

            //O(1)           //O(1)
            if (arr == null) throw new NullReferenceException();
            //O(1)
            bool swapHappened = true;
            //O(n)
            while(swapHappened) 
            {
                //O(1)
                swapHappened = false;
                //O(1)          //O(n)              //O(n)
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    //O(1)
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        //O(1)
                        T temp = arr[j];
                        //O(1)
                        arr[j] = arr[j + 1];
                        //O(1)
                        arr[j + 1] = temp;
                        //O(1)
                        swapHappened = true;
                    }
                }
            }
        }
    }
}

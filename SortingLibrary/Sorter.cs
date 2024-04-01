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

        /**
         * If array is empty, return null
         * Iterates through each element of the array
         *      i set to pos
         *      canSwap bool to false
         *      while till can't swap
         *      If i+1 is smaller than i and i is not -1
         *          swap
         *          i minus one
         *      else
         *          set cantSwap to true
         */
        public static void InsertionSort(T[] arr)
        {
            if (arr == null) throw new NullReferenceException();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool cantSwap = false;
                int pos = i;
                while(!cantSwap)
                {
                    if (pos != -1 && arr[pos].CompareTo(arr[pos + 1]) > 0 )
                    {
                        T temp = arr[pos];
                        arr[pos] = arr[pos + 1];
                        arr[pos + 1] = temp;
                        pos = pos - 1;
                    } else
                    {
                        cantSwap = true;
                    }
                }
            }
        }

        /**
        * If array is empty, return null
        * Iterates through each element of the array
        *       i set to pos
        *       Iterates through each element of the array (j starting at i)
        *           If pos is smaller than j+1
        *               pos = j
        *       swap i and pos
        */
        public static void SelectionSort(T[] arr)
        {
            if (arr == null) throw new NullReferenceException();

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                int pos = i;
                for (int j = 0 + i; j <= arr.Length - 1; j++)
                {
                    if (arr[pos].CompareTo(arr[j]) > 0)
                    {
                        pos = j;
                    }
                }
                T temp = arr[pos];
                arr[pos] = arr[i];
                arr[i] = temp;
            }
        }
    }
}

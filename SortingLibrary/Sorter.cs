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
         * Insertion sort starts off by checking if the array is null to quickly get rid of useless arrays.
         * After that, I make a for loop that iterates through the entire array to be sure to get each number in the array.
         * I set 2 variables "cantSwap" it tells the while statement later that if a swap cannot happen go to the next number 
         * and "pos" which is the pointer when moving the smaller number down the array.
         * I set a while with !cantswap to continue to go through the entire 'solved' array (<i).
         * After that it will grab the current pos and compare it to the one ahead by one. If it is less that pos it will swap 
         * and move pos down 1 to continue comparing till it reaches the begining of the array or it finds a number smaller than it.
         * This will sort using the Insertion sort method. 
         * 
         * Pseudo-code:
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
            // BIG-O O(n^2) 
            // Reason: Two loops depeding on size (and luck) of the array

            // O(1)          // O(1)
            if (arr == null) throw new NullReferenceException();

            //   0(1)       0(n)                O(1)
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // 0(1)
                bool cantSwap = false;
                // 0(1)
                int pos = i;
                // 0(n)
                while (!cantSwap)
                {
                        // 0(1)      // 0(1)
                    if (pos != -1 && arr[pos].CompareTo(arr[pos + 1]) > 0 )
                    {
                        // 0(1)
                        T temp = arr[pos];
                        // 0(1)
                        arr[pos] = arr[pos + 1];
                        // 0(1)
                        arr[pos + 1] = temp;
                        // 0(1)
                        pos = pos - 1;
                    } else
                    {
                        // 0(1)
                        cantSwap = true;
                    }
                }
            }
        }

        /**
        * Selection sort starts off by checking if the array is null like the other methods. 
        * First I make a for loop that goes through each element of the array.
        * I make pos the smallest number in the array first with i then I check every single element that is smaller than pos with another for loop that starts at i.
        * If I find a number smaller it will make that index the new pos. 
        * When it reaches the end of the array it will swap i and pos with each other. 
        * This will sort using the Selection sort method.
        * 
        * 
        * Pseudo-code:
        * If array is empty, return null
        * Iterates through each element of the array
        *       i set to pos
        *       Iterates through each element of the array (j starting at i)
        *           If pos is smaller than j
        *               pos = j
        *       swap i and pos
        */
        public static void SelectionSort(T[] arr)
        {
            // BIG-O O(n^2) 
            // Reason: Two loops depeding on size (and luck) of the array

            // O(1)          // O(1)
            if (arr == null) throw new NullReferenceException();
            //   0(1)    0(n)                    O(1)
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                // 0(1)
                int pos = i;
                //   0(1)           0(n)                 O(1)
                for (int j = 0 + i; j <= arr.Length - 1; j++)
                {
                        // 0(1)
                    if (arr[pos].CompareTo(arr[j]) > 0)
                    {
                        // 0(1)
                        pos = j;
                    }
                }
                // 0(1)
                T temp = arr[pos];
                // 0(1)
                arr[pos] = arr[i];
                // 0(1)
                arr[i] = temp;
            }
        }
    }
}

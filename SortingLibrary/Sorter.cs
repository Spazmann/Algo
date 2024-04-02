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
         * I create a for loop right after that starts at 1 becasue the the array is already sorted at 0 through 0.
         * I make three variables, one for the while loop, one to set pos which pos will go down the array to find where to insert the number,
         * and a variable that copys the current index.
         * I create the while loop that first checks the if the pos is 0 so that it doesn't cause out of index errors.
         * Then it copies the pos-1 to the current pos. This is what I changed so I can insert it later.
         * Lastly I create a if statement to check if pos in greater than number and if it is is will subtract pos by one,
         * but if it isn't it will insert the number in the array go back to the for loop.
         * 
         * Pseudo-code:
         * If array is empty, return null
         * Iterates through each element of the array
         *      i set to pos
         *      inserted bool to false
         *      store the number
         *      while till it has inserted
         *      if pos is equal to 0, insert number into index 0
         *      copy the pos - 1 to the current pos
         *      if the number is less than pos
         *          pos minus one
         *      else
         *          insert the number at pos
         */
        public static void InsertionSort(T[] arr)
        {
            // BIG-O O(n^2) 
            // Reason: Two loops depeding on size (and luck) of the array

            // O(1)          // O(1)
            if (arr == null) throw new NullReferenceException();

            //   0(1)       0(n)            O(1)
            for (int i = 1; i < arr.Length; i++)
            {
                // 0(1)
                bool inserted = false;
                // 0(1)
                int pos = i;
                // 0(1)
                T number = arr[i];
                // 0(n)
                while (!inserted)
                {
                    //  0(1)
                    if (pos == 0)
                    {
                        // 0(1)
                        arr[0] = number;
                        // 0(1)
                        break;
                    }
                    arr[pos] = arr[pos - 1];
                    //  0(1) 
                    if (number.CompareTo(arr[pos]) < 0 )
                    {
                        // 0(1)
                        pos--;
                    } else
                    {
                        // 0(1)
                        arr[pos] = number;
                        inserted = true;
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

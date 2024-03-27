using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Tests
{
    public static class SearchTesting
    {
        public static int SearchLinear(int[] numbers, int value)
        {
            if (numbers == null) return -1;

            for (int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i] == value) return i;
            }
            return -1;
        }
    }
}

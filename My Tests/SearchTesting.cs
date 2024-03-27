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
            foreach (int i in numbers)
            {
                if (i == value) return i;
            }
            return -1;
        }
    }
}

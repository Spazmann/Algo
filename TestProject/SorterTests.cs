using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace SortingLibraryTests
{
    [TestClass]
    public class SorterTests
    {
        private int itemsInArray = 100;
        protected int[] hunRand;
        protected int[] hunDesc;
        protected int[] hunAsc;
        protected string expected;

        #region setupCode

        public SorterTests()
        {
            hunRand = new int[itemsInArray];
            hunDesc = new int[itemsInArray];
            hunAsc = new int[itemsInArray];
            Random rand = new Random(12271978);
            for (int i = 0; i < hunRand.Length; i++)
            {
                hunRand[i] = rand.Next(100001);
            }

            //ten = mil.Take(10).ToArray();
            hunDesc = hunRand.OrderByDescending(x => x).ToArray();
            hunAsc = hunRand.OrderBy(x => x).ToArray();
            expected = ArrayToString(hunAsc);
        }

        protected int[] CloneRand
        {
            get { return (int[])hunRand.Clone(); }
        }

        protected int[] CloneDesc
        {
            get { return (int[])hunDesc.Clone(); }
        }

        protected int[] CloneAsc
        {
            get { return (int[])hunAsc.Clone(); }
        }

        protected string ArrayToString(int[] a)
        {
            StringBuilder sb = new StringBuilder();

            if (a.Length > 0)
            {
                sb.Append(a[0]);
                for (int i = 1; i < a.Length; i++)
                {
                    sb.Append(", ");
                    sb.Append(a[i]);
                }
            }

            return sb.ToString();
        }

        #endregion

        [TestMethod]
        public void ExampleTestMethod()
        {
            Assert.AreEqual(true, true);
        }

    }
}

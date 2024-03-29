using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingLibrary;
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

        [TestMethod]
        public void BubbleSortCanSortSmallArrayInDecendingOrder()
        {
            //Assemble
            int[] testArray = { 5, 4, 3, 2, 1 };
            int[] expectedResult = { 1, 2, 3, 4, 5 };

            //Act
            Sorter<int>.BubbleSort(testArray);

            //Assert
            CollectionAssert.AreEqual(expectedResult, testArray);
        }

        [TestMethod]
        public void BubbleSortSortsLargestNumberToTheEnd()
        {
            int[] testArray = { 10, 1, 2, 3, 4, 5, 6 };
            int expectedValue = 10;

            Sorter<int>.BubbleSort(testArray);

            Assert.AreEqual(expectedValue, testArray[testArray.Length - 1]);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void BubbleSortShouldThrowNullReferenceExeptionIfNullArrayIsPassed()
        {
            int[] testArray = null;

            Sorter<int>.BubbleSort(testArray);
        }

        [TestMethod]
        public void BubbleSortShouldThrowNullReferenceExeptionIfNullArrayIsPassed2()
        {
            int[] testArray = null;

            Assert.ThrowsException<NullReferenceException>(() => 
            { 
                Sorter<int>.BubbleSort(testArray); 
            });
        }

        [TestMethod]
        public void BubbleSortShouldSortCorrectlyIfDuplicatesExist()
        {
            int[] testArray = { 8, 5, 5, 5, 5, 1, 2, 3 };
            int[] expectedResult = { 1, 2, 3, 5, 5, 5, 5, 8 };

            Sorter<int>.BubbleSort(testArray);

            CollectionAssert.AreEqual(expectedResult, testArray);
        }

        [TestMethod]
        public void BubbleSortCorrectSortAnAlreadySortedArray()
        {
            int[] testArray = { 1, 2, 3, 4, 5 };
            int[] expectedResult = { 1, 2, 3, 4, 5 };

            Sorter<int>.BubbleSort(testArray);

            CollectionAssert.AreEqual(expectedResult, testArray);
        }

        [TestMethod]
        public void BubbleSortCanSortACollectionofPerson()
        {
            Person[] people = new Person[3];

            people[0] = new Person(5);
            people[1] = new Person(1);
            people[2] = new Person(0);

            Person[] expectedPerson = new Person[3];

            expectedPerson[0] = new Person(0);
            expectedPerson[1] = new Person(1);
            expectedPerson[2] = new Person(5);

            Sorter<Person>.BubbleSort(people);

            bool oneDidntMatch = false;
            for(int i = 0; i < people.Length; i++)
            {
                if (people[i].Id != expectedPerson[i].Id)
                {
                    oneDidntMatch |= true;
                    break;
                }
            }

            Assert.IsFalse(oneDidntMatch);
        }
    }
}

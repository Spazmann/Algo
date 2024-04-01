using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingLibrary;


namespace SortingLibraryTests
{
    [TestClass]
    public class SelectionTests
    {
        [TestMethod]
        public void SelectionSortCanSortSmallArrayInDecendingOrder()
        {
            int[] testArray = { 5, 4, 3, 2, 1 };
            int[] expectedResult = { 1, 2, 3, 4, 5 };

            Sorter<int>.SelectionSort(testArray);

            CollectionAssert.AreEqual(expectedResult, testArray);
        }

        [TestMethod]
        public void SelectionSortBasicTest()
        {
            int[] testArray = { 48, 13, 8, 38, 16, 1, 33, 25, 42, 50 };
            int[] expectedResult = { 1, 8, 13, 16, 25, 33, 38, 42, 48, 50 };

            Sorter<int>.SelectionSort(testArray);

            CollectionAssert.AreEqual(expectedResult, testArray);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SelectionSortReturnsErrorIfEmptyArray()
        {
            int[] nullArray = null;

            Sorter<int>.SelectionSort(nullArray);
        }

        [TestMethod]
        public void SelectionSortTestDuplicates()
        {
            int[] testArray = { 3, 3, 5, 2, 3, 1, 1, 5 };
            int[] expectedResult = { 1, 1, 2, 3, 3, 3, 5, 5 };

            Sorter<int>.SelectionSort(testArray);

            CollectionAssert.AreEqual(expectedResult, testArray);
        }

        [TestMethod]
        public void SelectionSortCanSortACollectionofPerson()
        {
            Person[] people = new Person[3];

            people[0] = new Person(5);
            people[1] = new Person(1);
            people[2] = new Person(0);

            Person[] expectedPerson = new Person[3];

            expectedPerson[0] = new Person(0);
            expectedPerson[1] = new Person(1);
            expectedPerson[2] = new Person(5);

            Sorter<Person>.SelectionSort(people);

            bool oneDidntMatch = false;
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Id != expectedPerson[i].Id)
                {
                    oneDidntMatch |= true;
                    break;
                }
            }

            Assert.IsFalse(oneDidntMatch);
        }

        [TestMethod]
        public void SelectionSortlargestNumberAtTheEnd()
        {
            int[] testArray = { 10, 1, 2, 3, 4, 5, 6 };
            int expectedValue = 10;

            Sorter<int>.SelectionSort(testArray);

            Assert.AreEqual(expectedValue, testArray[testArray.Length - 1]);
        }

    }
}


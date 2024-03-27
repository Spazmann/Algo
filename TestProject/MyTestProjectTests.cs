using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_Tests;

namespace TestProject
{
    [TestClass]
    public class MyTestProjectTests
    {
        [TestMethod]
        public void SearchLinearCanReturnFirstItemInArray()
        {
            int[] testArray = { 1, 2, 3 };
            int findValue = 1;
            int expectedIndex = 0;
            int returnIndex = SearchTesting.SearchLinear(testArray, findValue);

            Assert.AreEqual(expectedIndex, returnIndex);
        }

        [TestMethod]
        public void SearchLinearCanReturnLastItemInArray()
        {
            int[] testArray = { 5, 3, 8 };
            int findValue = 8;
            int expectedIndex = testArray.Length - 1;
            int returnIndex = SearchTesting.SearchLinear(testArray, findValue);

            Assert.AreEqual(expectedIndex, returnIndex);
        }

        [TestMethod]
        public void SearchLinearReturnsNegativeOneIfArrayPassedIsNull()
        {
            int[] testArray = null;
            int findValue = 30;
            int expectedIndex = -1;
            int returnIndex = SearchTesting.SearchLinear(testArray, findValue);

            Assert.AreEqual(expectedIndex, returnIndex);
        }

        [TestMethod]
        public void SearchLinearReturnsNegativeOneIfSearchValueDoesNotExist()
        {
            int[] testArray = { 5, 3, 2, 8, 10, 20 };
            int findValue = 90;
            int expectedIndex = -1;
            int resultIndex = SearchTesting.SearchLinear(testArray, findValue);

            Assert.AreEqual(expectedIndex, resultIndex);
        }

        [TestMethod]
        public void SearchLinearIfMultipleValuesInArrayReturnsFirstFoundIndex()
        {
            int[] testArray = { 3, 5, 5, 5, 5, 5 };
            int findValue = 5;
            int expectedIndex = 1;
            int resultIndex = SearchTesting.SearchLinear(testArray, findValue);

            Assert.AreEqual(expectedIndex, resultIndex);
        }
    }
}
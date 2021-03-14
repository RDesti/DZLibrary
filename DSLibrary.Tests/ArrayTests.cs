using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;


namespace DZLibrary.Tests
{
    class ArrayTests
    {
        public static int[] GetArrayMock(int number)
        {
            int[] result = new int[0];
            switch (number)
            {
                case 1:
                    result = new int[] { 744, 377, 984, 1000, 78, 876, 77, 168, 652, 121, 327, 934, 295, 966 };

                    break;
                case 2:
                    result = new int[] { 936, 606, 554, 639, 650 };
                    break;
                case 3:
                    result = new int[] { 368, 802, 317, 962, 331, 782, 392, 650 };
                    break;
                case 4:
                    result = new int[] { 89, 69, 72 };
                    break;
                case 5:
                    result = new int[] { 513 };
                    break;
            }
            return result;
        }
        [TestCase(1, 77)]
        [TestCase(2, 554)]
        [TestCase(3, 317)]
        [TestCase(4, 69)]
        [TestCase(5, 513)]

        public void FindMinElement_WhenArrayPassed_ShouldResult(int mockNumber, int expected)
        {
            int[] arr = ArrayTests.GetArrayMock(mockNumber);
            int actual = Array.FindMinElement(arr);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 1000)]
        [TestCase(2, 936)]
        [TestCase(3, 962)]
        [TestCase(4, 89)]
        [TestCase(5, 513)]

        public void FindMaxElement_WhenArrayPassed_ShouldResult(int mockNumber, int expected)
        {
            int[] arr = ArrayTests.GetArrayMock(mockNumber);
            int actual = Array.FindMaxElement(arr);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 6)]
        [TestCase(2, 2)]
        [TestCase(3, 2)]
        [TestCase(4, 1)]
        [TestCase(5, 0)]

        public void FindIndexMinElement_WhenArrayPassed_ShouldResult(int mockNumber, int expected)
        {
            int[] arr = ArrayTests.GetArrayMock(mockNumber);
            int actual = Array.FindIndexMinElement(arr);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 3)]
        [TestCase(2, 0)]
        [TestCase(3, 3)]
        [TestCase(4, 0)]
        [TestCase(5, 0)]

        public void FindIndexMaxElement_WhenArrayPassed_ShouldResult(int mockNumber, int expected)
        {
            int[] arr = ArrayTests.GetArrayMock(mockNumber);
            int actual = Array.FindIndexMaxElement(arr);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 4442)]
        [TestCase(2, 1245)]
        [TestCase(3, 3196)]
        [TestCase(4, 69)]
        [TestCase(5, 0)]

        public void SummElemWithOddIndex_WhenArrayPassed_ShouldResult(int mockNumber, int expected)
        {
            int[] arr = ArrayTests.GetArrayMock(mockNumber);
            int actual = Array.SummElemWithOddIndex(arr);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, new int[] { 966, 295, 934, 327, 121, 652, 168, 77, 876, 78, 1000, 984, 377, 744 })]
        [TestCase(2, new int[] { 650, 639, 554, 606, 936 })]
        [TestCase(3, new int[] { 650, 392, 782, 331, 962, 317, 802, 368 })]
        [TestCase(4, new int[] { 72, 69, 89 })]
        [TestCase(5, new int[] { 513 })]

        public void GetReversArray_WhenArrayPassed_ShouldResult(int mockNumber, int[] expected)
        {
            int[] arr = ArrayTests.GetArrayMock(mockNumber);
            int[] actual = Array.GetReversArray(arr);
            Assert.AreEqual(expected, actual);
        }
    }
}

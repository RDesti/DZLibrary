using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;


namespace DZLibrary.Tests
{
    class DoubleArrayTests
    {
        public static int[,] GetDoubleArrayMock(int number)
        {
            int[,] result = new int[0, 0];
            switch (number)
            {
                case 1:
                    result = new int[,]
                    {
                        { 744, 377, 984, 1000 },
                        { 78, 876, 77, 168 },
                        { 652, 121, 327, 934 },
                        { 295, 966, 11, 0 }
                    };
                    break;
                case 2:
                    result = new int[,]
                    {
                        { 936, 606 },
                        { 554, 639 }
                    };
                    break;
                case 3:
                    result = new int[,]
                    {
                    { 368, 802, 317 },
                    { 962, 331, 782},
                    { 392, 650, 10 }
                    };
                    break;
                case 4:
                    result = new int[,]
                    {
                        { 89, 69, 72 },
                        { 70, 73, 80 }
                    };
                    break;
                case 5:
                    result = new int[,]
                    {
                        { 513, 627, 351, 154, 110 },
                        { 707, 296, 834, 793, 429 },
                        { 62, 66, 7, 653, 651 },
                        { 288, 431, 421, 913, 954 },
                        { 669, 421, 142, 357, 640 },
                        { 39, 75, 526, 462, 942 },
                        { 783, 394, 774, 826, 346 },
                        { 785, 925, 218, 28, 725 },
                        { 615, 37, 114, 100, 53}
                    };
                    break;
            }
            return result;
        }
        [TestCase(1, 0)]
        [TestCase(2, 554)]
        [TestCase(3, 10)]
        [TestCase(4, 69)]
        [TestCase(5, 7)]

        public void FindMinElement_WhenArrayPassed_ShouldResult(int mockNumber, int expected)
        {
            int[,] arr = DoubleArrayTests.GetDoubleArrayMock(mockNumber);
            int actual = DoubleArray.FindMinElement(arr);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 1000)]
        [TestCase(2, 936)]
        [TestCase(3, 962)]
        [TestCase(4, 89)]
        [TestCase(5, 954)]

        public void FindMaxElement_WhenArrayPassed_ShouldResult(int mockNumber, int expected)
        {
            int[,] arr = DoubleArrayTests.GetDoubleArrayMock(mockNumber);
            int actual = DoubleArray.FindMaxElement(arr);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, new int[] {3, 3})]
        [TestCase(2, new int [] {1, 0})]
        [TestCase(3, new int[] {2, 2})]
        [TestCase(4, new int[] {0, 1})]
        [TestCase(5, new int[] {2, 2})]

        public void FindIndexMinElement_WhenArrayPassed_ShouldResult(int mockNumber, int[] expected)
        {
            int[,] arr = DoubleArrayTests.GetDoubleArrayMock(mockNumber);
            int[] actual = DoubleArray.FindIndexMinElement(arr);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, new int[] { 0, 3 })]
        [TestCase(2, new int[] { 0, 0 })]
        [TestCase(3, new int[] { 1, 0 })]
        [TestCase(4, new int[] { 0, 0 })]
        [TestCase(5, new int[] { 3, 4 })]

        public void FindIndexMaxElement_WhenDoubleArrayPassed_ShouldResult(int mockNumber, int[] expected)
        {
            int[,] arr = DoubleArrayTests.GetDoubleArrayMock(mockNumber);
            int[] actual = DoubleArray.FindIndexMaxElement(arr);
            Assert.AreEqual(expected, actual);
        }
    }
}

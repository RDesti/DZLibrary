using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;


namespace DZLibrary.Tests
{
    public class CyclesTests
    {
        [TestCase(0, 0, 1)]
        [TestCase(3, 1, 3)]
        [TestCase(-5, 7, -78125)]
        [TestCase(7, 7, 823543)]
        [TestCase(-1, 8, 1)]
        public void GetExponentiation_WhenABPassed_ShouldResult(double a, double b, double expected)
        {
            double actual = Cycles.GetExponentiation(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(500, new int[] { 0, 500, 1000 })]
        [TestCase(333, new int[] { 0, 333, 666, 999 })]
        [TestCase(99, new int[] { 0, 99, 198, 297, 396, 495, 594, 693, 792, 891, 990 })]
        [TestCase(150, new int[] { 0, 150, 300, 450, 600, 750, 900 })]
        public void GetNumbersThatMultiples_WhenNumberPassed_ShouldResult(int number, int[] expected)
        {
            int[] actual = Cycles.GetNumbersThatMultiples(number);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(10, 4)]
        [TestCase(21, 5)]
        [TestCase(1, 1)]
        [TestCase(0, 0)]
        [TestCase(400, 20)]
        public void CountSquareNumberIsLessThanGivenNum_WhenNumberPassed_ShouldResult(int a, int expected)
        {
            int actual = Cycles.CountSquareNumberIsLessThanGivenNum(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(17, 1)]
        [TestCase(21, 7)]
        [TestCase(115, 23)]
        [TestCase(525, 175)]
        [TestCase(400, 200)]
        public void GetGreatestDivisorOfNumber_WhenNumberPassed_ShouldResult(int a, int expected)
        {
            int actual = Cycles.GetGreatestDivisorOfNumber(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0, 0, 0)]
        [TestCase(3, 1, 0)]
        [TestCase(-5, 7, 7)]
        [TestCase(7, 7, 7)]
        [TestCase(61, 13, 245)]
        public void GetSummNumbThatMultiples7_WhenABPassed_ShouldResult(int a, int b, int expected)
        {
            int actual = Cycles.GetSummNumbThatMultiples7(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(9, 34)]
        [TestCase(5, 5)]
        [TestCase(4, 3)]
        public void GetNumberOfLineFibonacci_WhenNumberPassed_ShouldResult(int number, int expected)
        {
            int actual = Cycles.GetNumberOfLineFibonacci(number);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0, 0, 0)]
        [TestCase(33, 11, 11)]
        [TestCase(5, 7, 1)]
        [TestCase(100, 75, 25)]
        [TestCase(17, 9, 1)]
        public void GetGreatestCommonDivisor_WhenABPassed_ShouldResult(int a, int b, int expected)
        {
            int actual = Cycles.GetGreatestCommonDivisor(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(27, 3)]
        [TestCase(1, 1)]
        [TestCase(125, 5)]
        [TestCase(64, 4)]
        public void FindNumberByBinarySearch_WhenNumberPassed_ShouldResult(int number, int expected)
        {
            int actual = Cycles.FindNumberByBinarySearch(number);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(222227, 1)]
        [TestCase(157464, 3)]
        [TestCase(9, 1)]
        [TestCase(0, 0)]
        [TestCase(22224864, 0)]
        public void CountNumberOddDigits_WhenNumberPassed_ShouldResult(int number, int expected)
        {
            int actual = Cycles.CountNumberOddDigits(number);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(222227, 722222)]
        [TestCase(157464, 464751)]
        [TestCase(9, 9)]
        [TestCase(0, 0)]
        [TestCase(12345678, 87654321)]
        public void GetReverstNumber_WhenNumberPassed_ShouldResult(int number, int expected)
        {
            int actual = Cycles.GetReverstNumber (number);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(80, new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24, 26, 28, 34, 36, 38, 40, 41, 42, 43, 44, 46, 48, 56, 58, 60, 61, 62, 63, 64, 65, 66, 68, 78, 80 })]
        [TestCase(33, new int[] { 2,4,6,8,12,14,16,18,20,21,22,24,26,28 })]
        [TestCase(9, new int[] { 2,4,6,8 })]
        [TestCase(1, new int[] { })]
        public void GetValueSumEvenIsGreaterSumOdd_WhenNumberPassed_ShouldResult(int number, int[] expected)
        {
            int[] actual = Cycles.GetValueSumEvenIsGreaterSumOdd(number);
            Assert.AreEqual(expected, actual);
        }
        [TestCase( 222227, 722222, "YES")]
        [TestCase( 146, 751, "YES")]
        [TestCase( 9, 1, "NO")]
        [TestCase( 1000, 124578, "YES")]
        [TestCase( 1234, 8765555, "NO")]
        public void HaveInNumbersIdenticalDigits_WhenTwoNumberPassed_ShouldResult(int number1, int number2, string expected)
        {
            string actual = Cycles.HaveInNumbersIdenticalDigits(number1, number2);
            Assert.AreEqual(expected, actual);
        }
    }
}

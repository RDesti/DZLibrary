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
        [TestCase(157464, 54)]
        [TestCase(9, 1)]
        [TestCase(125, 5)]
        [TestCase(64, 4)]
        public void FindNumberByBinarySearch_WhenNumberPassed_ShouldResult(int number, int expected)
        {
            int actual = Cycles.FindNumberByBinarySearch(number);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(27, 3)]
        [TestCase(54, 157464)]
        [TestCase(9, 1)]
        [TestCase(1, 0)]
        [TestCase(64, 4)]
        public void CountNumberOddDigits_WhenNumberPassed_ShouldResult(int number, int expected)
        {
            int actual = Cycles.CountNumberOddDigits(number);
            Assert.AreEqual(expected, actual);
        }
    }
}

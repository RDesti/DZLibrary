using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace DZLibrary.Tests
{
    public class BranchingTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 1, 4)]
        [TestCase(-5, 7, -12)]
        [TestCase(7, 7, 49)]
        [TestCase(-10, -8, -2)]
        public void GetSumOrMultiplyOrMinus_WhenABPassed_ShouldResult(double a, double b, double expected)
        {
            double actual = Branching.GetSumOrMultiplyOrMinus(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(7, 5, "точка в первой четверти")]
        [TestCase(-3, 6, "точка во второй четверти")]
        [TestCase(-5, -7, "точка в третьей четверти")]
        [TestCase(8, -2, "точка в четвертой четверти")]
        public void DetermineInWhichQuarterPoint_WhenXYPassed_ShouldQuarter(int x, int y, string expected)
        {
            string actual = Branching.DetermineInWhichQuarterPoint(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0, 1.5, 1.5, "0 1,5 1,5")]
        [TestCase(11, 8.5, 6, "6 8,5 11")]
        [TestCase(2.75, 10, 5, "2,75 5 10")]
        [TestCase(5, -7, 7, "-7 5 7")]
        [TestCase(8, -8, -6, "-8 -6 8")]
        [TestCase(12.5, 64, -83, "-83 12,5 64")]
        public void GetNumbersInAscendingOrder_WhenABPassed_ShouldResult(double a, double b, double c, string expected)
        {
            string actual = Branching.GetNumbersInAscendingOrder(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(5, 3, 1, "Уравнение не имеет решений")]
        [TestCase(1, 325, 1, "x1 = -0,003076952208118655 x2 = -324,9969230477919")]
        [TestCase(1, 2, 1, "x = -1")]
        public void GetSolveToQuadraticEquation_WhenABCPassed_ShouldResult(double a, double b, double c, string expected)
        {
            string actual = Branching.GetSolveToQuadraticEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(10, "десять")]
        [TestCase(21, "двадцать один")]
        [TestCase(99, "девяносто девять")]
        [TestCase(15, " пятьнадцать")]
        [TestCase(40, "сорок")]
        public void PrintInLettersNumber_WhenNumberPassed_ShouldResult(int number, string expected)
        {
            string actual = Branching.PrintInLettersNumber(number);
            Assert.AreEqual(expected, actual);
        }
    }
}

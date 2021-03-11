using NUnit.Framework;

namespace DZLibrary.Tests
{
    public class VariablesTests
    {
        [TestCase(0, 1.5, 1.5)]
        [TestCase(2.75, 0, -5)]
        [TestCase(5, 7, 37)]
        [TestCase(-8, -2, -6)]
        [TestCase(120.5, 64, -83.159292035398224)]
        public void GetResultOfLinearEquation_WhenABPassed_ShouldResult(double a, double b, double expected)
        {
            double actual = Variables.GetResultOfEquation(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(-1, 2, 2, -1)]
        [TestCase(5, -4, -4, 5)]
        [TestCase(1, 1, 1, 1)]
        [TestCase(-4, -8, -8, -4)]
        [TestCase(101, 1001, 1001, 101)]
        public void GetSwap_WhenABPassed_Should(double a, double b, double expectedA, double expectedB)
        {
            Variables.GetSwap(ref a, ref b);
            double actualA = a;
            double actualB = b;
            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
        }
        [TestCase(1, 1, new double[] { 1, 0 })]
        [TestCase(17, -1, new double[] { -17, 0 })]
        [TestCase(10, 20, new double[] { 0.5, 10 })]
        [TestCase(-16, 7, new double[] { -2.2857142857142856, -2 })]
        [TestCase(0, 1, new double[] { 0, 0 })]
        public void GetDivisionAndRemainder_WhenABPassed_ShouldResult(double a, double b, double[] expected)
        {
            double[] actual = Variables.GetDivisionResultAndRemainder(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 1, 1, 0)]
        [TestCase(1, 2, 3, 1)]
        [TestCase(16, 10, -20, -1.875)]
        public void GetSolutionOfLinearEquation_WhenABCPassed_ShouldResult(double a, double b, double c, double expected)
        {
            double actual = Variables.GetSolutionLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(5, 3, -20, 4, new double[] { -0.04, 3.2})]
        [TestCase(16, 0, 0, -5, new double[] {0.3125, -5})]
        [TestCase(0, 0, 2, 4, new double[] { 2, 0})]
        public void GetEquationOfStraightLine_WhenX1Y1X2Y2Passed_ShouldResult(double x1, double y1, double x2, double y2, double[] expected)
        {
            double[] actual = Variables.GetEquationOfStraightLine(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }
    }
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
            string actual = Branching.DetermineInWhichQuarterPoint ( x, y);
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
            string actual = Branching.PrintInLettersNumber (number);
            Assert.AreEqual(expected, actual);
        }

    }
}
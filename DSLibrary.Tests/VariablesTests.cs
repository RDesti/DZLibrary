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
}
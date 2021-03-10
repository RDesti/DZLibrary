using System;
using System.Collections.Generic;
using System.Text;

namespace DZLibrary
{
    class Variables
    {
        public static double GetResultOfDivision(double a, double b)
        {
            if (a == b)
            {
                throw new Exception("Вводимые значения а и b не должны быть равны!");
            }
            return (5 * a + b * b) / (b - a);
        }
        public static void GetSwap(ref double a, ref double b)
        {
            double swap;
            swap = a;
            a = b;
            b = swap;
        }
        public static double[] GetDivisionResultAndRemainder(double a, double b)
        {
            double [] array= new double [2];
            if (b==0)
            {
                throw new Exception("Значение b не может быть равно 0");
            }
            array[0] = a / b;
            array[1] = a % b;
            return array;
        }
        public static double GetSolutionLinearEquation(double a, double b, double c)
        {
            if (a==0)
            {
                throw new Exception("Значение a не может быть равно 0");
            }
            return (c - b) / a;
        }
        public static double[] GetEquationOfStraightLine(double x1, double y1, double x2, double y2)
        {
            double[] array = new double[2];
            if (x1==x2)
            {
                throw new Exception("Вводимые значения координат x1 и x2 не должны совпадать!");
            }
            double a = (y2 - y1) / (x2 - x1);
            double b = y2 - a * x2;
            array[0] = a;
            array[1] = b;
            return array;
        }
    }
}

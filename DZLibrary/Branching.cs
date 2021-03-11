using System;
using System.Collections.Generic;
using System.Text;

namespace DZLibrary
{
    public static class Branching
    {
        public static double GetSumOrMultiplyOrMinus(double a, double b)
        {
            if (a > b)
            {
                return a + b;
            }
            else if (a == b)
            {
                return a * b;
            }
            else
            {
                return a - b;
            }
        }
        public static string DetermineInWhichQuarterPoint(int x, int y)
        {
            if (x == 0 || y == 0)
            {
                throw new Exception("Значение х и y должно быть отличным от 0!");
            }
            string result = "";
            if (x > 0)
            {
                if (y > 0)
                {
                    result = "точка в первой четверти";
                }
                else
                {
                    result = "точка в четвертой четверти";
                }
            }
            else
            {
                if (y > 0)
                {
                    result = "точка в второй четверти";
                }
                else
                {
                    result = "точка в третьей четверти";
                }
            }
            return result;
        }
        public static string GetNumbersInAscendingOrder(double a, double b, double c)
        {
            string result = "";
            if (a <= b && a <= c)
            {
                if (b <= c)
                {
                    result = $"{ a} { b} { c}";
                }
                else
                {
                    result = $"{ a} { c} { b}";
                }
            }
            else if (b <= a && b <= c)
            {
                if (a <= c)
                {
                    result = $"{ b} { a} { c}";
                }
                else
                {
                    result = $"{ b} { c} { a}";
                }
            }
            else if (c <= a && c <= b)
            {
                if (a <= b)
                {
                    result = $"{ c} { a} { b}";
                }
                else
                {
                    result = $"{ c} { b} { a}";
                }
            }
            return result;
        }
        public static string GetSolveToQuadraticEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new Exception("Значение а не может быть равным 0!");
            }
            string result = "";
            double D = b * b - 4 * a * c;
            if (D > 0)
            {
                result = $"x1 = {(-b + Math.Sqrt(D)) / 2 * a}";
                result += $" x2 = {(-b - Math.Sqrt(D)) / 2 * a}";
                return result;
            }
            else if (D == 0)
            {
                result = $"x = {(-b + Math.Sqrt(D)) / 2 * a}";
                return result;
            }
            else
            {
                result = "Уравнение не имеет решений";
                return result;
            }
        }
        public static string PrintInLettersNumber(int number)
        {
            if (number < 10 || number > 99)
            {
                throw new Exception("Необходимо ввести целое положительное двузначное число!");
            }
            string result = "";
            int remainder = number % 10;
            int division = number / 10;
            switch (division)
            {
                case 2:
                    result = "двадцать ";
                    break;
                case 3:
                    result = "тридцать ";
                    break;
                case 4:
                    result = "сорок ";
                    break;
                case 5:
                    result = "пятьдесят ";
                    break;
                case 6:
                    result = "шестьдесят ";
                    break;
                case 7:
                    result = "семьдесят ";
                    break;
                case 8:
                    result = "восемьдесят ";
                    break;
                case 9:
                    result = "девяносто ";
                    break;
            }
            switch (remainder)
            {
                case 1:
                    if (division >= 2 && division <= 9)
                    {
                        result += "один";
                    }
                    else
                    {
                        result += "оди";
                    }
                    break;
                case 2:
                    if (division >= 2 && division <= 9)
                    {
                        result += "два";
                    }
                    else
                    {
                        result += "две";
                    }
                    break;
                case 3:
                    result += "три";
                    break;
                case 4:
                    if (division >= 2 && division <= 9)
                    {
                        result += "четыре";
                    }
                    else
                    {
                        result += "четыр";
                    }
                    break;
                case 5:
                    result += "пять";
                    break;
                case 6:
                    result += "шесть";
                    break;
                case 7:
                    result += "семь";
                    break;
                case 8:
                    result += "восемь";
                    break;
                case 9:
                    result += "девять";
                    break;
            }
            switch (division)
            {
                case 1:
                    if (number == 10)
                    {
                        result += "десять";
                    }
                    else
                    {
                        result += "надцать";
                    }
                    break;
            }
            return result;
        }
    }
}

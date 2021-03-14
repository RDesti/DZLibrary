using System;
using System.Collections.Generic;
using System.Text;

namespace DZLibrary
{
    public static class Cycles
    {
        public static double GetExponentiation(double a, double b)
        {
            double c = 1;
            for (double i = 0; i < b; i++)
            {
                c *= a;
            }
            return c;
        }
        public static int[] GetNumbersThatMultiples(int number)
        {
            int size = (1000 / number) + 1;
            int[] array = new int[size];
            int j = 0;
            for (int i = 0; i <= 1000; i += number)
            {
                array[j++] = i;
            }
            return array;
        }
        public static int CountSquareNumberIsLessThanGivenNum(int a)
        {
            int count = 0;
            for (int i = 0; i < a; i++)
                if ((i * i) < a)
                {
                    count++;
                }
            return count;
        }
        public static int GetGreatestDivisorOfNumber(int a)
        {
            int i;
            for (i = a / 2; a % i != 0; i--) ;
            return i;
        }
        public static int GetSummNumbThatMultiples7(int a, int b)
        {
            int summ = 0;
            if (a > b)
            {
                for (int i = b; i <= a; i++)
                {
                    if (i % 7 == 0)
                    {
                        summ += i;
                    }
                }
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 7 == 0)
                    {
                        summ += i;
                    }
                }
            }
            return summ;
        }
        public static int GetNumberOfLineFibonacci(int number)
        {
            int a = 1;
            int b = 1;
            int sum = 1;
            int k = number - 2;
            for (int i = 0; i < k; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            return sum;
        }
        public static int GetGreatestCommonDivisor(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
        public static int FindNumberByBinarySearch(int number)
        {
            int left = 0;
            int right = number;
            int middle = right;
            while (number != middle * middle * middle)
            {
                if ((middle * middle * middle) > number)
                {
                    right = middle;
                }
                else
                {
                    left = middle;
                }
                middle = (left + right) / 2;
            }
            return middle;
        }
        public static int CountNumberOddDigits(int number)
        {
            int remainder;
            int count = 0;
            while (number != 0)
            {
                remainder = number % 10;
                if (remainder % 2 != 0)
                {
                    count++;
                }
                number /= 10;
            }
            return count;
        }
        public static int GetReverstNumber(int number)
        {
            int remainder;
            int revers = 0;

            while (number != 0)
            {
                remainder = number % 10;
                revers += remainder;
                revers *= 10;
                number /= 10;
            }
            revers /= 10;
            return revers;
        }
        public static int [] GetValueSumEvenIsGreaterSumOdd(int number)
        {
            int remainder;
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                int SumOdds = 0;
                int SumEvens = 0;
                int tempI = i;
                while (tempI != 0)
                {
                    remainder = tempI % 10;
                    if (remainder % 2 == 0)
                    {
                        SumEvens += remainder;
                    }
                    else
                    {
                        SumOdds += remainder;
                    }
                    tempI /= 10;
                }
                if (SumEvens > SumOdds)
                {
                    ++count;
                }
            }
            int[] value = new int[count];
            int j = 0;
            for (int i = 1; i <= number; i++)
            {
                int SumOdds = 0;
                int SumEvens = 0;
                int tempI = i;
                while (tempI != 0)
                {
                    remainder = tempI % 10;
                    if (remainder % 2 == 0)
                    {
                        SumEvens += remainder;
                    }
                    else
                    {
                        SumOdds += remainder;
                    }
                    tempI /= 10;
                }
                if (SumEvens > SumOdds)
                {
                    value[j] = i;
                    j++;
                }
            }
            return value;
        }
        public static string HaveInNumbersIdenticalDigits(int number1, int number2)
        {
            string result = string.Empty;
            int b;
            int c;
            int i = 0;
            do
            {
                int tempNumber2 = number2;
                b = number1 % 10;
                do
                {
                    c = tempNumber2 % 10;
                    if (b == c)
                    {
                        i++;
                    }
                    tempNumber2 /= 10;
                }
                while (tempNumber2 != 0);
                number1 /= 10;
            }
            while (number1 != 0 || b == c);
            if (i > 0)
            {
                result = "YES";
            }
            else
            {
                result = "NO";
            }
            return result;
        }
    }
}

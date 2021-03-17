using System;
using System.Collections.Generic;
using System.Text;

namespace DZLibrary
{
    public static class Array
    {
        public static int[] CreateAndFill(int sizeArray)
        {
            int[] array = new int[sizeArray];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 1001);
                Console.Write($"{array[i]} ");
            }
            return array;
        }
        public static int FindMinElement(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }
        public static int FindMaxElement(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        public static int FindIndexMinElement(int [] array)
        {
            int min = array[0];
            int minIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }
        public static int FindIndexMaxElement(int [] array)
        {
            int max = array[0];
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        public static int SummElemWithOddIndex(int [] array)
        {
            int summ = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (j % 2 != 0)
                {
                    summ += array[j];
                }
            }
            return summ;
        }
        public static int [] GetReversArray(int [] array)
        {
            for (int j = 0; j < array.Length/2; j++)
            {
                int revers = array[j];
                array[j] = array[array.Length - j - 1];
                array[array.Length - j - 1] = revers;
            }
            return array;
        }
        public static int GetCountOfOddElements(int [] array)
        {
            int count = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] % 2 != 0)
                {
                    count ++;
                }
            }
            return count;
        }
        public static int[] GetSwapedHalves(int[] array)
        {
            int halvesLength = array.Length / 2;
            for(int j = 0; j < halvesLength; j++)
            {
                int temp = array[j];
                array[j] = array[halvesLength + j];
                array[halvesLength + j] = temp;
            }
            return array;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DZLibrary
{
    public static class DoubleArray
    {
        public static int[,] CreateAndFill(int a, int b)
        {
            int[,] array = new int[a, b];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 101);
                }
            }
            return array;
        }
        public static int FindMinElement(int[,] array)
        {
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;
        }
        public static int FindMaxElement(int[,] array)
        {
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }
        public static int[] FindIndexMinElement(int[,] array)
        {
            int min = array[0, 0];
            int[] minIndex = new int[2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                        minIndex[0] = i;
                        minIndex[1] = j;
                    }
                }
            }
            return minIndex;
        }
        public static int[] FindIndexMaxElement(int[,] array)
        {
            int max = array[0, 0];
            int[] maxIndex = new int[2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                        maxIndex[0] = i;
                        maxIndex[1] = j;
                    }
                }
            }
            return maxIndex;
        }
    }
}

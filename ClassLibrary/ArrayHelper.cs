using System;

namespace ClassLibrary
{
    public class ArrayHelper
    {
        public static void Sort(int[] array)
        {
            Array.Sort(array);
        }

        public static int Max(int[,] matrix)
        {
            if(matrix == null || matrix.Length == 0)
            {
                throw new ArgumentException();
            }

            int max = matrix[0, 0];
            foreach (var item in matrix)
            {
                if(item > max)
                {
                    max = item;
                }
            }

            return max;
        }
    }
}

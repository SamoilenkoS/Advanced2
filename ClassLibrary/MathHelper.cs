using System;

namespace ClassLibrary
{
    public class MathHelper
    {
        public static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public static int GetDivisionResult(int a, int b)
        {
            if(b == 0)
            {
                throw new ArgumentException("B is equal to zero!");
            }

            return a / b;
        }
    }
}

using System;

namespace ConsoleAdvanced
{
    class Program
    {
        public static int Max(int a, int b, int c)
        {
            return a > b ? (a > c ? a : c) : (b > c ? b : c);
        }

        public static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        static void Main(string[] args)
        {
            var max = Max(4, 5, 3);
            Console.WriteLine(max);
        }
    }
}

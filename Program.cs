using System;

namespace FunWithExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n****\nI'm done!!!\n****\n");
        }
        public static int divideInts(int a, int b)
        {
            return a / b;
        }
        public static int getSafeInt()
        {
            return int.Parse(Console.ReadLine());
        }
        public static int sumOfNumbers(int[] numbers, int length)
        {
            int total = 0;
            foreach (var num in numbers)
            {
                total += num;
            }
            return total;
        }
    }
}

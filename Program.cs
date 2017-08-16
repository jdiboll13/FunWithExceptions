using System;

namespace FunWithExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Pick another number.");
            int b = int.Parse(Console.ReadLine());
            divideInts(a, b);

            Console.WriteLine();

            Console.WriteLine("\n****\nI'm done!!!\n****\n");
        }
        public static int divideInts(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't divide by zero. Try a different number.");
                b = int.Parse(Console.ReadLine());
                return divideInts(a, b);
            }
            
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

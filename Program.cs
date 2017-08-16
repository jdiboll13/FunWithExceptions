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

            Console.WriteLine("Enter a number.");
            getSafeInt();

            int[] numbers = {12, 23, 45, 15};
            int length = 4;
            sumOfNumbers(numbers, length);

            Console.WriteLine("\n****\nI'm done!!!\n****\n");
        }
        public static int divideInts(int a, int b)
        {
            try
            {
                Console.WriteLine(a /b);
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
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("you did not enter a number"); 
                return getSafeInt();
            }
        }
        public static int sumOfNumbers(int[] numbers, int length)
        {
            try
            {
                if (length == numbers.Length)
                {
                    int total = 0;
                    foreach (var num in numbers)
                    {
                        total += num;
                    }
                    Console.WriteLine("Numbers is the proper length.");
                    return total;
                }
                else
                {
                    throw new Exception();
                }
                
            }
            catch (Exception)
            {
                Console.WriteLine("Numbers is not the proper length.");
                return 0;
            }

        }
    }
}

using System;

namespace S5_L49_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number: ");
            var input = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}! = {1}", input, Factorial(input));
        }

        private static int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number * Factorial(number - 1);
        }
    }
}

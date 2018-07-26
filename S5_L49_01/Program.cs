using System;

namespace S5_L49_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var divisibles = 0;

            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    divisibles++;
                }
            }

            Console.WriteLine("How many numbers between 1 and 100 are divisible by 3 with no remainder: {0}", divisibles);
        }
    }
}

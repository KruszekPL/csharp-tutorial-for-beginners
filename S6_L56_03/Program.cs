using System;
using System.Collections.Generic;

namespace S6_L56_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                Console.Write("Enter number: ");
                var input = int.Parse(Console.ReadLine());
                
                if (numbers.Contains(input))
                {
                    Console.WriteLine("Error! This number already exists...");
                    continue;
                }

                numbers.Add(input);
            }

            numbers.Sort();

            var sortedNumbers = String.Join(',', numbers);

            Console.WriteLine("Your numbers are: {0}.", sortedNumbers);
        }
    }
}

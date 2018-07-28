using System;
using System.Collections.Generic;
using System.Linq;

namespace S6_L56_05
{
    class Program
    {
        static void Main(string[] args)
        {
            var validation = false;
            var numbers = new List<int>();

            while (!validation)
            { 
                Console.Write("Enter a list of comma separated numbers (e.g 5, 1, 9, 2, 10): ");
                var input = Console.ReadLine();

                numbers
                    .AddRange(input.Trim()
                    .Replace(" ", "")
                    .Split(',')
                    .Select(Int32.Parse)
                    .ToArray());

                if (!(String.IsNullOrEmpty(input) || numbers.Count < 5))
                {
                    validation = true;
                }
            }

            numbers.Sort();


            var result = new String(String.Join(',', numbers.GetRange(0,3)));

            Console.WriteLine("3 smallest numbers in the list: {0}", result);
        }
    }
}

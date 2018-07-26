using System;
using System.Collections.Generic;

namespace S6_L56_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers (Quit to end):");
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("> ");
                var input = Console.ReadLine();
                if (input.ToLower().Equals("quit"))
                {
                    break;
                }

                var number = int.Parse(input);
                if (!numbers.Contains(number))
                {
                numbers.Add(number);
                }
            }

            var result = String.Join(',', numbers);
            Console.WriteLine("Your numbers are: {0}", result);
        }
    }
}

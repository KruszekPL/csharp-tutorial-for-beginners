using System;
using System.Linq;

namespace S8_L67_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a few numbers separated by a hyphen: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                return;
            }

            var numbers = input
                            .Split('-')
                            .Select(Int32.Parse)
                            .ToArray();
            Array.Sort(numbers);
            var duplicates = false;

            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    duplicates = true;
                    break;
                }
            }

            Console.WriteLine(duplicates ? "Duplicates" : "No Duplicates");
        }
    }
}

using System;
using System.Linq;

namespace S8_L67_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a few numbers separated by a hyphen: ");
            var input = Console.ReadLine();
            var numbers = input
                            .Split('-')
                            .Select(Int32.Parse)
                            .ToArray();
            Array.Sort(numbers);
            var consecutive = true;

            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] != numbers[i] - 1)
                {
                    consecutive = false;
                    break;
                }
            }

            Console.WriteLine(consecutive ? "Consecutive" : "Not Consecutive");
        }
    }
}

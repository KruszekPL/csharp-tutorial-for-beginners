using System;

namespace S5_L49_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers separated by comma: ");
            var input = Console.ReadLine();
            var numbers = input.Split(',');

            var max = Convert.ToInt32(numbers[0]);
            foreach (var number in numbers)
            {
                if (Convert.ToInt32(number) > max)
                {
                    max = Convert.ToInt32(number);
                }
            }
                Console.WriteLine("Maximum is: {0}", max);
        }
    }
}

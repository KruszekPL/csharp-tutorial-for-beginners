using System;

namespace S5_L49_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            while (true)
            {
                Console.Write("Enter value (ok - ends): ");
                var input = Console.ReadLine();
                if (input.Equals("ok"))
                {
                    break;
                }
                sum += int.Parse(input);
            }
            Console.WriteLine("Sum of entered values: {0}", sum);
        }
    }
}

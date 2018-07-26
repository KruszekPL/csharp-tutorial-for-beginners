using System;

namespace S5_L43_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number (1 - 10): ");
            var input = Console.ReadLine();
            var inputNo = Int32.Parse(input);
            if (inputNo >= 1 && inputNo <= 10)
            {
                Console.WriteLine("Valid!");
            }
            else
            {
                Console.WriteLine("Invalid!");
            }
        }
    }
}

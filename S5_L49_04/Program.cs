using System;

namespace S5_L49_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var secretNumber = random.Next(1, 10);

            for (var chances = 4; chances > 0; chances--)
            {
                Console.Write("Guess secret number: ");
                var input = int.Parse(Console.ReadLine());
                
                if (input == secretNumber)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }
            Console.WriteLine("You lost!");
        }
    }
}

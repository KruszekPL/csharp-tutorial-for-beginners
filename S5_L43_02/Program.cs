using System;

namespace S5_L43_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            var inputOne = Console.ReadLine();
            Console.Write("Enter second number: ");
            var inputTwo = Console.ReadLine();
            var no1 = int.Parse(inputOne);
            var no2 = int.Parse(inputTwo);

            Console.WriteLine("{0} is greater.", no1 > no2 ? no1 : no2);

        }
    }
}

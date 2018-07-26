using System;

namespace S6_L56_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            var name = Console.ReadLine();

            var charName = name.ToCharArray();
            Array.Reverse(charName);

            var reversedName = new String(charName);

            Console.WriteLine("Reversed name: {0}", reversedName);
        }
    }
}

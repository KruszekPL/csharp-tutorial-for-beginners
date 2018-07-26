using System;
using System.Collections.Generic;

namespace S6_L56_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<string>();

            while (true)
            {
                Console.Write("Enter name (press ENTER to finish): ");
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                users.Add(input);
            }

            switch(users.Count)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("{0} likes your post.", users[0]);
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} like your post.", users[0], users[1]);
                    break;
                default:
                    Console.WriteLine("{0}, {1} and {2} others like your post.", users[0], users[1], users.Count - 2);
                    break;
            }
        }
    }
}

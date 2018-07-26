using System;

namespace S5_L43_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the speed limit: ");
            var speedLimit = int.Parse(Console.ReadLine());

            Console.Write("Please enter speed of a car: ");
            var currentSpeed = int.Parse(Console.ReadLine());

            if (currentSpeed > speedLimit)
            {
                var demeritPoints = (currentSpeed - speedLimit) / 5;
                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended!");
                }
                else
                {
                    Console.WriteLine("Your demerit Points are: {0}", demeritPoints);
                }
            }
            else
            {
                Console.WriteLine("OK!");
            }
        }
    }
}

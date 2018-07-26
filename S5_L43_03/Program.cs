using System;

namespace S5_L43_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter width of the image: ");
            var inputX = int.Parse(Console.ReadLine());
            Console.Write("Enter height of the image: ");
            var inputY = int.Parse(Console.ReadLine());

            Console.WriteLine("Image is {0}.", inputX > inputY ? "landscape" : "portrait");
        }
    }
}

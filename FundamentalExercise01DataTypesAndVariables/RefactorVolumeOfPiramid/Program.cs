using System;

namespace RefactorVolumeOfPiramid
{
    class Program
    {
        static void Main(string[] args)
        {
            //double dul, sh, V = 0;
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            double result = 0;
            result = (length * width * height) / 3.00;
            Console.WriteLine($"Pyramid Volume: {result:f2}");

        }
    }
}

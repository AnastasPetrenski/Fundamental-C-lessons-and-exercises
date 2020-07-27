using System;

namespace StaticSecondExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Point.PointsCount = 1555; //Global instance for the class
            Console.WriteLine(Point.PointsCount) ;

            Point lowerLeft = Point.RandomPoint(); //new Point() { x = -5, y = -9 };
            lowerLeft.PrintPoint();
            Point upperRigth = Point.RandomPoint(); //new Point() { x = 5, y = 9 };
            upperRigth.PrintPoint();

            Console.WriteLine(lowerLeft.isThirdQuadrant());
            while (!lowerLeft.isThirdQuadrant())
            {
                lowerLeft = Point.RandomPoint();
                Console.WriteLine($"Generating point: ");
                lowerLeft.PrintPoint();
            }
            Console.WriteLine(lowerLeft.isThirdQuadrant());
        }
    }
}

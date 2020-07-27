using System;
using System.Collections.Generic;
using System.Text;

namespace StaticSecondExample
{
    public class Point
    {
        public static int PointsCount;
        public int x;
        public int y;

        public bool isThirdQuadrant()
        {
            if (x < 0 && y < 0)
            {
                return true;
            }
            return false;
        }

        public static void PrintPointStatic(Point point )
        {
            Console.WriteLine($"x: {point.x}, y: {point.y} ");
        }

        public void PrintPoint()
        {
            Console.WriteLine($"x: {this.x}, y: {this.y} ");
        }

        public static Point RandomPoint()
        {
            Random rand = new Random();
            return new Point() { x = rand.Next(-100, 100), y = rand.Next(-100, 100) };
        }
    }
}

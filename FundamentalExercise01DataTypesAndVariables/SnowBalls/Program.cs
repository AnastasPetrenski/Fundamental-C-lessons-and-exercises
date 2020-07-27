using System;
using System.Numerics;

namespace SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballsMade = int.Parse(Console.ReadLine());
            BigInteger theBiggestSnowball = int.MinValue;
            int theBiggestSnow = 0;
            int theBiggestTime = 0;
            int theBiggestQuality = 0;
            for (int i = 0; i < snowballsMade; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger ballSize = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                if (ballSize > theBiggestSnowball)
                {
                    theBiggestSnowball = ballSize;
                    theBiggestSnow = snowballSnow;
                    theBiggestTime = snowballTime;
                    theBiggestQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{theBiggestSnow} : {theBiggestTime} = {theBiggestSnowball} ({theBiggestQuality})");
        }
    }
}

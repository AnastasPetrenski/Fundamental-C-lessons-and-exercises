using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            int length = int.Parse(Console.ReadLine());
            string inputDNS = string.Empty;
            int[] maxOnesSequence = new int[length];
            int maxCount = 0;
            int maxIndex = 0;
            int maxSum = 0;
            int bestSample = 0;
            int sample = 1;
            while ((inputDNS = Console.ReadLine()) != "Clone them!")
            {
                int[] dns = inputDNS
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int index = 0;
                int count = 1;
                int sum = 0;
                bool start = false;
                for (int i = 0; i < dns.Length; i++)
                {
                    if (dns.Length == 1)
                    {
                        break;
                    }
                    else if (dns[i] == 1 && dns[i + 1] == 1)
                    {
                        if (!start)
                        {
                            index = i;
                        }
                        count++;
                        start = true;
                    }
                    if (i+1 == dns.Length-1)
                    {
                        break;
                    }

                }
                foreach (var item in dns)
                {
                    sum += item;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxIndex = index;
                    maxSum = sum;
                    maxOnesSequence = dns;
                    bestSample = sample;
                }
                else if (index < maxIndex)
                {
                    maxCount = count;
                    maxIndex = index;
                    maxSum = sum;
                    maxOnesSequence = dns.ToArray();
                    bestSample = sample;
                }
                else if (sum > maxSum)
                {
                    maxCount = count;
                    maxIndex = index;
                    maxSum = sum;
                    maxOnesSequence = dns;
                    bestSample = sample;
                }
                sample++;
            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {maxSum}.");
            Console.WriteLine(string.Join(" ", maxOnesSequence));
        }
    }
}

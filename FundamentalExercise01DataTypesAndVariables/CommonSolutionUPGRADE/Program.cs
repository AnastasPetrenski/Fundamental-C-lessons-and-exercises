﻿using System;

namespace CommonSolutionUPGRADE
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();
            //Extra Constrain: if we have 1 elements equal to 2 elements of arr1, remove duplicate element and print only unique value
            string[] uniqueValues = new string[arr2.Length];
            for (int i = 0; i < arr2.Length; i++)
            {
                //bool isUnique = false;
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr2[i] == arr1[j]) //&& !isUnique)
                    {
                        //isUnique = true;
                        Console.Write(arr2[i] + " ");
                        uniqueValues[i] = arr2[i];
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(uniqueValues.Length);
            Console.WriteLine(string.Join(", ", uniqueValues));
        }
    }
}

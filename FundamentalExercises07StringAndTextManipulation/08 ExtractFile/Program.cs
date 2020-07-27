using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> pathFile = Console.ReadLine().Split('\\', StringSplitOptions.RemoveEmptyEntries).ToList();
            int index = pathFile[pathFile.Count - 1].IndexOf(".");
            string fileName = pathFile[pathFile.Count - 1].Substring(0, index);
            string fileExtension = pathFile[pathFile.Count - 1].Substring(index+1, pathFile[pathFile.Count - 1].Length -1 - index);
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char[] arr = StringBuilderAppend(start, end).ToCharArray();
            List<string> list = new List<string>();
            list.AddRange(new string[] {"aas", "asddf", "adff"});
            string lista = StringBuilderInsert(list);
            Console.WriteLine(string.Join(" ", lista));
        }

        static string StringBuilderInsert(List<string> list)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var items in list)
            {
                stringBuilder.Append(items);
            }
            int item = 1;
            stringBuilder.Insert(0, item);
            return stringBuilder.ToString();
        }

        static string StringBuilderAppend(char start, char end) 
        {

            StringBuilder result = new StringBuilder();
            if (end < start)
            {
                char temp = start;
                start = end;
                end = temp;
            }
            for (int i = start+1; i < end; i++)
            {
                result.Append((char)i);
            }
            return result.ToString();
        }
    }
}

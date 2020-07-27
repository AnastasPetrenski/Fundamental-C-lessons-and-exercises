using System;
using System.Collections.Generic;

namespace _18_HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();
            List<string> comments = new List<string>();
            string command = string.Empty;
            Console.WriteLine("<h1>");
            Console.WriteLine($"    {title}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"    {content}");
            Console.WriteLine("</article>");
            while ((command = Console.ReadLine()) != "end of comments")
            {
                comments.Add(command);
                Console.WriteLine("<div>");
                Console.WriteLine($"    {command}");
                Console.WriteLine("</div>");
            }
        }
    }
}

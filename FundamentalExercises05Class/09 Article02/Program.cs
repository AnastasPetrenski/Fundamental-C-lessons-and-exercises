using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_Article02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> input = new List<string>();
            List<Article> articles = new List<Article>();
            for (int i = 0; i < number; i++)
            {
                input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
                Article article = new Article(input[0], input[1], input[2]);
                articles.Add(article);
            }
            string orderBy = Console.ReadLine();
            articles = Article.OrderArticles(articles, orderBy);
            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
    }

    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article( string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public static List<Article> OrderArticles(List<Article> articles, string orderBy)
        {
            List<Article> ordered = new List<Article>();
            if (orderBy == "title")
            {
                ordered = articles.OrderBy(x => x.Title).ToList();
            }
            else if (orderBy == "content")
            {
                ordered = articles.OrderBy(x => x.Content).ToList();
            }
            else if (orderBy == "author")
            {
                ordered = articles.OrderBy(x => x.Author).ToList();
            }
            return ordered;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}"; 
        }
    }
}

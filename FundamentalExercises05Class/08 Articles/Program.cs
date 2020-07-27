using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_Articles
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            //Article.ReadArticle(input);
            Article article = new Article(input[0], input[1], input[2]);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<string> commands = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (commands.Contains("Edit"))
                {
                    Article.EditContent(article, commands[1]);
                }
                else if (commands.Contains("ChangeAuthor"))
                {
                    Article.ChangeAuthor(article, commands[1]);
                }
                else if (commands.Contains("Rename"))
                {
                    Article.RenameTitle(article, commands[1]);
                }
            }
            Console.WriteLine(article.ToString());
        }
    }

    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        //public Article()
        //{

        //}

        //public static Article ReadArticle(List<string> input)
        //{
        //    Article article = new Article();
        //    article.Title = input[0];
        //    article.Content = input[1];
        //    article.Author = input[2];
        //    return article;
        //}

        public static Article EditContent(Article article, string newArticle)
        {
            article.Content = newArticle;
            return article;
        }

        public static Article ChangeAuthor(Article article, string newAuthor)
        {
            article.Author = newAuthor;
            return article;
        }

        public static Article RenameTitle(Article article, string newTitle)
        {
            article.Title = newTitle;
            return article;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}

using System;
using System.Collections.Generic;

namespace _07_AdvertismentMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> phrases = new List<string>() { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            List<string> events = new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            List<string> authors = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<string> cities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Advert.GenerateFakeAdvert(phrases, events, authors, cities, n);

        }
    }

    public class Advert
    {
        public string Phrases { get; set; }
        public string Events { get; set; }
        public string Authors { get; set; }
        public string Cities { get; set; }

        public Advert()
        {

        }

        public static void GenerateFakeAdvert(List<string> phrases, List<string> events, List<string> authors, List<string> cities, int n)
        {

            List<Advert> str = new List<Advert>();
            for (int i = 0; i < n; i++)
            {
                Random rand = new Random();
                Advert phrase = new Advert();
                int start = 0;
                phrase.Phrases = phrases[rand.Next(start, phrases.Count - 1)];
                phrase.Events = events[rand.Next(start, events.Count - 1)];
                phrase.Authors = authors[rand.Next(start, authors.Count - 1)];
                phrase.Cities = cities[rand.Next(start, cities.Count - 1)];
                str.Add(phrase);
            }
            //str = $"{phrases[rand.Next(start, phrases.Count - 1)]} {events[rand.Next(start, events.Count - 1)]} {authors[rand.Next(start, authors.Count - 1)]} - {cities[rand.Next(start, cities.Count - 1)]}";
            foreach (var item in str)
            {
                Console.WriteLine($"{item.Phrases} {item.Events} {item.Authors} - {item.Cities}");
            }
        }
    }
}

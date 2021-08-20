using System;

namespace AdMsg
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPhrases = int.Parse(Console.ReadLine());
            Random rng = new Random();
            MessageParts parts = new MessageParts();
            for (int i = 0; i < numberOfPhrases; i++)
            {
                Console.WriteLine($"{parts.phrases[rng.Next(parts.phrases.Length)]} {parts.events[rng.Next(parts.events.Length)]} {parts.authors[rng.Next(parts.authors.Length)]} – {parts.cities[rng.Next(parts.cities.Length)]}");
            }

        }
    }

    public class MessageParts
    {
        public string[] phrases = {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."};
        public string[] events = {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};
        public string[] authors = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
        public string[] cities = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};
    }
}

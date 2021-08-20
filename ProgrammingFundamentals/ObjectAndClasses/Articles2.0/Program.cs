using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            int numberOfArticles = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                articles.Add(new Article(input[0], input[1], input[2]));
            }
            string criteria = Console.ReadLine();
            switch (criteria)
            {
                case "title":
                    articles = articles.OrderBy(x => x.Title).ToList();
                    break;
                case "content":
                    articles = articles.OrderBy(x => x.Content).ToList();
                    break;
                case "author":
                    articles = articles.OrderBy(x => x.Author).ToList();
                    break;
                default:
                    break;
            }
            foreach (var item in articles)
            {
                Console.WriteLine(item.ToString());
            }
        }

        class Article
        {
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }

            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public void Edit(string newContent)
            {
                Content = newContent;
            }

            public void ChangeAuthor(string newAuthor)
            {
                Author = newAuthor;
            }

            public void Rename(string newTitle)
            {
                Title = newTitle;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}

using System;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleParts = Console.ReadLine().Split(", ");
            Article article = new Article(articleParts[0], articleParts[0], articleParts[0]);
            int commands = int.Parse(Console.ReadLine());
            for (int i = 0; i < commands; i++)
            {
                string[] input = Console.ReadLine().Split(": ");
                switch (input[0])
                {
                    case "Rename":
                        article.Rename(input[1]);
                        break;
                    case "Edit":
                        article.Edit(input[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(input[1]);
                        break;
                    default:
                        break;
                }
                Console.WriteLine(article.ToString());
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

namespace _02.Articles
{
    internal class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split(", ")
                .ToList();

            int commandsCount = int.Parse(Console.ReadLine());

            Article article = new Article(input[0], input[1], input[2]);

            for (int i = 0; i < commandsCount; i++)
            {
                string[] tokens = Console.ReadLine().Split(": ").ToArray();
                string command = tokens[0];
                string content = tokens[1];

                if (command == "Edit")
                {
                    article.Edit(content);
                }

                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(content);
                }

                else if (command == "Rename")
                {
                    article.Rename(content);
                }
            }

            Console.WriteLine(article);
        }

        public class Article
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

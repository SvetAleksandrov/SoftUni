namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string title = command[0];
                string content = command[1];
                string author = command[2];

                Article article = new Article (title, content, author);
                articles.Add(article);
            }

            foreach (Article article in articles)
            {
                Console.WriteLine (article);
            }
        }
    }
}
class Article
{
    public string Title { get; private set; }

    public string Content { get; private set; }

    public string Author { get; private set; }


    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}
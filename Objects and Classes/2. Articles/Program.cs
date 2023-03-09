namespace _2._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string[] input = Console.ReadLine()
                     .Split(", ");

                string title = input[0];
                string content = input[1];
                string author = input[2];

                Article newArticle = new Article(title, content, author);

                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    string[] command = Console.ReadLine()
                        .Split(": ");

                    if (command[0] == "Edit")
                    {
                        newArticle.Edit(command[1]);
                    }
                    else if (command[0] == "ChangeAuthor")
                    {
                        newArticle.ChangeAuthor(command[1]);
                    }
                    else if (command[0] == "Rename")
                    {
                        newArticle.Rename(command[1]);
                    }
                }
                Console.WriteLine(newArticle);
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
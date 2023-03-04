namespace School_Libery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine()
                .Split('&', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] cmdArg = command.Split('|', StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArg[0].Trim();

                switch (cmdType)
                {
                    case "Add Book":
                        string bookName = cmdArg[1].Trim();
                        if (!books.Contains(bookName))
                        {
                            books.Insert(0, bookName);
                        }
                        break;

                    case "Take Book":
                        string bookName1 = cmdArg[1].Trim();
                        if (books.Contains(bookName1))
                        {
                            books.Remove(bookName1);
                        }
                        break;

                    case "Swap Books":
                        string bookNameA = cmdArg[1].Trim();
                        string bookNameB = cmdArg[2].Trim();
                        int indexA = books.IndexOf(bookNameA);
                        int indexB = books.IndexOf(bookNameB);

                        if (indexA >= 0 && indexB >= 0)
                        {
                            books[indexA] = bookNameB;
                            books[indexB] = bookNameA;
                        }
                        break;

                    case "Insert Book":
                        string bookName3 = cmdArg[1].Trim();
                        if (!books.Contains(bookName3))
                        {
                            books.Add(bookName3);
                        }
                        break;

                    case "Check Book":
                        int index = int.Parse(cmdArg[1].Trim());
                        if (index >= 0 && index < books.Count)
                        {
                            Console.WriteLine(books[index]);
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", books));
        }
    }
}
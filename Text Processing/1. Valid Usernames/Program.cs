namespace _1._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] users = Console.ReadLine().Split(", ");

            foreach (var currentName in users)
            {
                if (currentName.Length > 3 && currentName.Length <= 16)
                {
                    bool isValidUser = true;

                    foreach (var currnetChar in currentName)
                    {
                        if (!(char.IsLetterOrDigit(currnetChar) || currnetChar == '-' || currnetChar == '_'))
                        {
                            isValidUser = false;
                            break;
                        }
                    }
                    if (isValidUser)
                    {
                        Console.WriteLine(currentName);
                    }
                }
            }

        }
    }
}
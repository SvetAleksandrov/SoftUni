namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();

            //int index = secondWord.IndexOf(firstWord);

            //while (index != -1)
            //{
            //    secondWord = secondWord.Remove(index, firstWord.Length);
            //    index = secondWord.IndexOf(firstWord);
            //}

            //Console.WriteLine(secondWord);

            while (secondWord.Contains(firstWord))
            {
                secondWord = secondWord.Replace(firstWord, string.Empty);
            }

            Console.WriteLine(secondWord);

        }
    }
}
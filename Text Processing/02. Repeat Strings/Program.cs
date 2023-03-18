using System.Text;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            StringBuilder result = new StringBuilder();

            foreach (string word in input)
            {
                int wordLength = word.Length;

                for (int i = 0; i < wordLength; i++)
                {
                    result.Append(word);
                }
            }

            Console.WriteLine(result);
        }
    }
}
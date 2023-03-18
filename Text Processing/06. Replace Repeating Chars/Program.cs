using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder(text);

            char previousLetter = text[0];
            

            for (int i = 1; i < sb.Length; i++)
            {
                if (previousLetter == sb[i])
                {
                    sb.Remove(i, 1);
                    i--; // Decrement i so that we check the same index again
                }
                else
                {
                    previousLetter = sb[i];
                }   
            }
            text = sb.ToString();

            Console.WriteLine(text);
        }
    }
}
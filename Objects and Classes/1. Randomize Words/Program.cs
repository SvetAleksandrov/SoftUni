namespace _1._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                Random randomWords = new Random();
                int randomIndex = randomWords.Next(words.Length);

                string currentWords = words[i];
                string wordsToSwap = words[randomIndex];

                words[i] = wordsToSwap;
                words[randomIndex] = currentWords;

            }
            Console.WriteLine(String.Join(Environment.NewLine, words));
        }
    }
}
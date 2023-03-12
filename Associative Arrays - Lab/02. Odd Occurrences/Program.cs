namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> count = new Dictionary<string, int>();


            foreach (string word in words)
            {
                string wordToLowerCase = word.ToLower();

                if (!count.ContainsKey(wordToLowerCase))
                {
                    count.Add(wordToLowerCase, 1);
                }
                else
                {
                    count[wordToLowerCase]++;
                }
            }

            foreach (var item in count)
            {
                if (item.Value % 2 !=0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
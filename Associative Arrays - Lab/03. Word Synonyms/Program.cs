namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> listWords = new Dictionary<string, List<string>>();


            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonyms = Console.ReadLine();

                if (!listWords.ContainsKey(word))
                {
                    listWords.Add(word, new List<string>());
                }

                listWords[word].Add(synonyms);
                
            }

            foreach (var word in listWords)
            {
                //•	{word}
                //•	{ synonym}
                Console.Write(word.Key + " - ");
                Console.WriteLine(String.Join(", ", word.Value));
            }
        }
    }
}
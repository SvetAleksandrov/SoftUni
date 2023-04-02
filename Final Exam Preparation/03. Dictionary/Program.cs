namespace _03._Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> wordsDictionary = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(" | ");
            for (int i = 0; i < input.Length; i++)
            {
                string[] wordsDefinitions = input[i].Split(": ");
                string word = wordsDefinitions[0];
                string definition = wordsDefinitions[1];

                if (!wordsDictionary.ContainsKey(word))
                {
                    wordsDictionary.Add(word, new List<string>());
                    wordsDictionary[word].Add(definition);
                }

                else if (!wordsDictionary[word].Contains(definition))
                {
                    wordsDictionary[word].Add(definition);
                }
            }

            List<string> teacherList = new List<string>();

            string[] inputTeacherWords = Console.ReadLine().Split(" | ");
            foreach (var item in inputTeacherWords)
            {
                teacherList.Add(item);
            }

            // third Line

            string command = Console.ReadLine();

            if (command == "Hand Over")
            {
                Console.WriteLine(string.Join(" ", wordsDictionary.Keys));
            }
            else
            {
                foreach (var word in teacherList)
                {
                    if (wordsDictionary.ContainsKey(word))
                    {
                        Console.WriteLine($"{word}:");
                        foreach (var def in wordsDictionary[word])
                        {
                            Console.WriteLine($" -{def}");
                        }
                    }
                }
            }
        }
    }
}
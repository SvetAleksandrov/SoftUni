using System.Diagnostics.Tracing;

namespace _8._Anonymous_Threat__v1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "merge")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    FixInvalidIndex(words, ref startIndex, ref endIndex);
                    MergeText(words, startIndex, endIndex);
                }
                else if (cmdType == "divide")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int partisions = int.Parse(cmdArgs[2]);

                    string word = words[index];

                    List<string> partitionList = DivideWord(word, partisions);

                    words.RemoveAt(index);
                    words.InsertRange(index, partitionList);

                }
            }
            Console.WriteLine(String.Join(" ", words));

        }
        static void FixInvalidIndex(List<string> words, ref int startIndex, ref int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }

            if (startIndex >= words.Count)
            {
                startIndex = words.Count - 1;
            }

            if (endIndex <= 0)
            {
                endIndex = 0;
            }

            if (endIndex >= words.Count)
            {
                endIndex = words.Count - 1;
            }
        }
        static void MergeText(List<string> words, int startIndex, int endIndex)
        {
            string mergedText = string.Empty;

            for (int i = startIndex; i <= endIndex; i++)
            {
                string currentWord = words[startIndex];
                mergedText += currentWord;
                words.RemoveAt(startIndex);
            }
            words.Insert(startIndex, mergedText);
        }

        static List<string> DivideWord(string word, int partitions)
        {

            int substrincsLenght = word.Length / partitions;
            int lastSubstringLength = substrincsLenght + word.Length % partitions;

            List<string> partisionsList = new List<string>();

            for (int i = 0; i < partitions; i++)
            {
                int desireLenght = substrincsLenght;
                if (i == partitions - 1)
                {
                    desireLenght = lastSubstringLength;
                }


                char[] newPartionArr = word
                    .Skip(i * substrincsLenght)
                    .Take(desireLenght)
                    .ToArray();
                string newPartion = string.Join("", newPartionArr);
                partisionsList.Add(newPartion);
            }
            return partisionsList;
        }
    }
}
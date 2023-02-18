using System.Collections.Concurrent;
using System.IO;

namespace _8._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split()
                .ToList();

            string command = Console.ReadLine();

            while (command != "3:1")

            {
                string[] cmdArg = command
                    .Split();

                string action = cmdArg[0];

                int index = int.Parse(cmdArg[1]);

                switch (action)
                {
                    case "merge":
                        int endIndex = int.Parse(cmdArg[2]);
                        MergeElements(elements, ref index, ref endIndex);
                        break;
                    case "divide":
                        int partitions = int.Parse(cmdArg[2]);
                        DivideElement(elements, index, partitions);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", elements));
        }

        static void MergeElements(List<string> elements, ref int startIndex, ref int endIndex)
        {
            if (startIndex < 0)
                startIndex = 0;
            if (endIndex >= elements.Count)
                endIndex = elements.Count - 1;

            if (startIndex >= endIndex)
                return;

            string merged = string.Concat(elements.GetRange(startIndex, endIndex - startIndex + 1));
            elements.RemoveRange(startIndex, endIndex - startIndex + 1);
            elements.Insert(startIndex, merged);
        }

        static void DivideElement(List<string> elements, int index, int partitions)
        {
            string element = elements[index];
            int partLength = element.Length / partitions;
            int remainingLength = element.Length % partitions;

            List<string> dividedParts = new List<string>();

            int currentIndex = 0;
            for (int i = 0; i < partitions; i++)
            {
                int currentPartLength = partLength;
                if (remainingLength > 0)
                {
                    currentPartLength++;
                    remainingLength--;
                }
                string currentPart = element.Substring(currentIndex, currentPartLength);
                dividedParts.Add(currentPart);
                currentIndex += currentPartLength;
            }

            elements.RemoveAt(index);
            elements.InsertRange(index, dividedParts);
        }
    }
}

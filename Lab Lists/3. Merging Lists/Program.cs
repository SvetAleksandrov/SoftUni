using System.ComponentModel;

namespace _3._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOne = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> listTwo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> mergeList = new List<int>();
            int minValue = Math.Min(listOne.Count, listTwo.Count);

            for (int i = 0; i < minValue; i++)
            {
                mergeList.Add(listOne[i]);
                mergeList.Add(listTwo[i]);
            }

            if (listOne.Count > listTwo.Count)
            {
                for (int i = minValue; i < listOne.Count; i++)
                {
                    mergeList.Add(listOne[i]);
                }
            }
            else if (listTwo.Count > listOne.Count)
            {
                for (int i = minValue; i < listTwo.Count; i++)
                {
                    mergeList.Add(listTwo[i]);
                }
            }
            Console.WriteLine(String.Join(' ', mergeList));
        }
    }
}
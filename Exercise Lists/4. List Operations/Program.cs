using System.Runtime.ExceptionServices;

namespace _4._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArg = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArg[0];

                if (cmdType == "Add")
                {
                    int numberToAdd = int.Parse(cmdArg[1]);
                    numbers.Add(numberToAdd);
                }
                else if (cmdType == "Insert")
                {
                    int numberToInsert = int.Parse(cmdArg[1]);
                    int indexToInsert = int.Parse(cmdArg[2]);

                    if (IsIndexValid(numbers, indexToInsert))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(indexToInsert, numberToInsert);
                }
                else if (cmdType == "Remove")
                {
                    int indexToRemove = int.Parse(cmdArg[1]);

                    if (IsIndexValid(numbers, indexToRemove))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(indexToRemove);
                }
                else if (cmdType == "Shift")
                {
                    string directions = cmdArg[1];
                    int count = int.Parse(cmdArg[2]);

                    if (directions == "left")
                    {
                        ShiftLeftSide(numbers, count);
                    }
                    else if (directions == "right")
                    {
                        ShiftRightSide(numbers, count);
                    }
                }
            }
            Console.WriteLine(String.Join(' ', numbers));

        }
        static bool IsIndexValid(List<int> numbers, int index)
            => index < 0 || index >= numbers.Count;

        static void ShiftLeftSide(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int firstNumber = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(firstNumber);
            }

        }
        static void ShiftRightSide(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int lastNumber = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastNumber);
            }

        }
    }
}
using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            int[] initialIndexes = Console.ReadLine().Split().Select(int.Parse).Where(x => x >= 0 && x < fieldSize).ToArray();

            foreach (int index in initialIndexes)
            {
                field[index] = 1;
            }

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split();
                int ladybugIndex = int.Parse(tokens[0]);
                string direction = tokens[1];
                int flyLength = int.Parse(tokens[2]);

                if (ladybugIndex >= 0 && ladybugIndex < fieldSize && field[ladybugIndex] == 1)
                {
                    field[ladybugIndex] = 0;

                    int currentIndex = ladybugIndex;
                    while (true)
                    {
                        if (direction == "right")
                        {
                            currentIndex += flyLength;
                        }
                        else
                        {
                            currentIndex -= flyLength;
                        }

                        if (currentIndex < 0 || currentIndex >= fieldSize)
                        {
                            break;
                        }

                        if (field[currentIndex] == 1)
                        {
                            continue;
                        }
                        else
                        {
                            field[currentIndex] = 1;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}

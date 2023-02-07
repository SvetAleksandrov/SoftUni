int length = int.Parse(Console.ReadLine());

int bestStart = -1;
int bestLength = -1;
int bestSum = int.MinValue;
int bestIndex = 0;
int index = 0;

List<int[]> dnaSequences = new List<int[]>();

string input = Console.ReadLine();

while (input != "Clone them!")
{
    int[] arr = input
        .Split("!", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    dnaSequences.Add(arr);

    int currentStart = -1;
    int currentLength = 0;
    int currentSum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        currentSum += arr[i];

        if (arr[i] == 1)
        {
            if (currentStart == -1)
            {
                currentStart = i;
            }

            currentLength++;

            if (currentLength > bestLength)
            {
                bestStart = currentStart;
                bestLength = currentLength;
                bestSum = currentSum;
                bestIndex = index;
            }
            else if (currentLength == bestLength)
            {
                if (currentStart < bestStart)
                {
                    bestStart = currentStart;
                    bestLength = currentLength;
                    bestSum = currentSum;
                    bestIndex = index;
                }
                else if (currentStart == bestStart && currentSum > bestSum)
                {
                    bestStart = currentStart;
                    bestLength = currentLength;
                    bestSum = currentSum;
                    bestIndex = index;
                }
            }
        }
        else
        {
            currentStart = -1;
            currentLength = 0;
            currentSum = 0;
        }
    }

    input = Console.ReadLine();
    index++;
}

Console.WriteLine($"Best DNA sample {bestIndex + 1} with sum: {bestSum}.");
Console.WriteLine(string.Join(" ", dnaSequences[bestIndex]));

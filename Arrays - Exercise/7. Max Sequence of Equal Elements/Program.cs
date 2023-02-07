string[] arrString = Console.ReadLine()
    .Split(' ');

int[] arr = new int[arrString.Length];

for (int i = 0; i < arrString.Length; i++)
{
    arr[i] = int.Parse(arrString[i]);
}

int currentStart = 0;
int currentLength = 1;
int bestStart = 0;
int bestLength = 1;

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] == arr[i - 1])
    {
        currentLength++;
        if (currentLength > bestLength)
        {
            bestStart = currentStart;
            bestLength = currentLength;
        }
    }
    else
    {
        currentStart = i;
        currentLength = 1;
    }
}

for (int i = bestStart; i < bestStart + bestLength; i++)
{
    Console.Write(arr[i] + " ");
}

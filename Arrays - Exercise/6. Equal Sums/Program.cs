string input = Console.ReadLine();

string[] stringArr = input.Split(" ");

int[] arr = new int[stringArr.Length];

for (int i = 0; i < stringArr.Length; i++)
{
    arr[i] = int.Parse(stringArr[i]);
}

int leftSum = 0;
int rightSum = 0;

for (int i = 1; i < arr.Length; i++)
{
    rightSum += arr[i];
}

for (int i = 0; i < arr.Length; i++)
{
    if (leftSum == rightSum)
    {
        Console.WriteLine(i);
        return;
    }

    leftSum += arr[i];
    if (i + 1 < arr.Length)
    {
        rightSum -= arr[i + 1];
    }
}

Console.WriteLine("no");

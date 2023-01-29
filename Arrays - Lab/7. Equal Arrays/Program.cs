int[] firstArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] secondtArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int sum = 0;
bool isFalse = false;

for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i] != secondtArray[i])
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        isFalse = true;
        break;
    }
    else
    {
        int currentNumber = firstArray[i];
        sum += currentNumber;
    }
}
if (isFalse)
{

}
else
{
    Console.WriteLine($"Arrays are identical. Sum: {sum}");

}
int[] number = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int sumEven = 0;

for (int i = 0;i < number.Length; i++)
{

    int currentNumber = number[i];
    if (currentNumber % 2 == 0)
    {
        sumEven += currentNumber;
    }

}
Console.WriteLine(sumEven);
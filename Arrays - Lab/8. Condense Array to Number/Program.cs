using System.Diagnostics.CodeAnalysis;

int[] number = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

for(int i = 0;i < number.Length-1; i++)
{
    for (int j = 0; j < number.Length - 1 - i; j++)
    {
        number[j] = number[j] + number[j + 1];
     }

}

Console.WriteLine(number[0]);
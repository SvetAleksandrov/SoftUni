using System.Diagnostics.CodeAnalysis;

int n = int.Parse(Console.ReadLine());

int[] wagons = new int[n];

int peopleCount = 0;

for (int i = 0; i < wagons.Length; i++)
{
    int currentWagon = int.Parse(Console.ReadLine());
    wagons[i] = currentWagon;

    peopleCount += currentWagon;
}
Console.WriteLine(string.Join(" ", wagons));
Console.WriteLine(peopleCount);  
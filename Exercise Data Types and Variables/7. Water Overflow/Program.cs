int numberOfLines = int.Parse(Console.ReadLine());

int tankCapacity = 255;

int currentCapacity = 0;

for (int i = 0; i < numberOfLines; i++)
{
    int input = int.Parse((Console.ReadLine()));

    currentCapacity += input;

    if (currentCapacity > tankCapacity)
    {
        Console.WriteLine("Insufficient capacity!");
        currentCapacity -= input;
    }
}
Console.WriteLine(currentCapacity);
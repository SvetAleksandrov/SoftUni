int numberOfLines = int.Parse(Console.ReadLine());

int sum = 0;
int i = 0;

while (i<numberOfLines)
{
    char symbol = char.Parse(Console.ReadLine());

    sum += (int)symbol;

    i++;
}
Console.WriteLine($"The sum equals: {sum}");

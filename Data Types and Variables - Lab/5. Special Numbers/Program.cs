int.TryParse(Console.ReadLine(), out int input);

for (int i = 1; i <= input; i++)
{
    int sum = 0;
    int number = i;

    for (int j = number; j > 0; j = j / 10)
    {
        sum += j % 10;
    }

    if (sum == 5 || sum == 7 || sum == 11)
    {
        Console.WriteLine($"{number} -> True");
    }
    else
    {
        Console.WriteLine($"{number} -> False");
    }
}

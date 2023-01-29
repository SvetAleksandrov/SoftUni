//0.9 1.5 2.4 2.5 3.14
double[] numbers = Console.ReadLine()
    .Split(' ')
    .Select(double.Parse)
    .ToArray();

//0.9 => 1

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == -0)
    {
        numbers[i] = 0;
    }
    Console.WriteLine($"{numbers[i]} => {(int)Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
}
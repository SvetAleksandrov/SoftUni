int input = int.Parse(Console.ReadLine());
int sum = 0;
int currentNumber = 0;
bool ifSpecial = false;

for (int i = 1; i <= input; i++)
{
    currentNumber = i;
    while (i > 0)
    {
        sum += i % 10;
        i = i / 10;
    }
    ifSpecial = (sum == 5) || (sum == 7) || (sum == 11);
    Console.WriteLine("{0} -> {1}", currentNumber, ifSpecial);
    sum = 0;
    i = currentNumber;
}

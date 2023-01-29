int startingYield = int.Parse(Console.ReadLine());

int daysOfHarves = 0;
int sum = 0;
int spicePerDay = 0;

while (startingYield >= 100)
{
    daysOfHarves++;

    spicePerDay = startingYield - 26;
    sum += spicePerDay;

    startingYield -= 10 ;
}
if (daysOfHarves > 0)
{
    sum -= 26; 
}
Console.WriteLine(daysOfHarves);
Console.WriteLine(sum);
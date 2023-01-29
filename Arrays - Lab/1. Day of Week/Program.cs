string[] dayOfWeeks = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"  };

int currentDay = int.Parse(Console.ReadLine());

if (currentDay >= 1 && currentDay <= 7)
{
    Console.WriteLine(dayOfWeeks[currentDay - 1]);
}
else
{
    Console.WriteLine("Invalid day!");
}
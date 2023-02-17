using System.Linq;

namespace _7._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputs = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            string command = Console.ReadLine();

            bool isChange = false;

            while (command != "end")
            {
                string[] commandInfo = command.Split();

                if (commandInfo[0] == "Add")
                {
                    int number = int.Parse(commandInfo[1]);
                    inputs.Add(number);
                    isChange = true;
                }
                else if (commandInfo[0] == "Remove")
                {
                    int number = int.Parse(commandInfo[1]);
                    inputs.Remove(number);
                    isChange = true;

                }
                else if (commandInfo[0] == "RemoveAt")
                {
                    int number = int.Parse(commandInfo[1]);
                    inputs.RemoveAt(number);
                    isChange = true;

                }
                else if (commandInfo[0] == "Insert")
                {
                    int number = int.Parse(commandInfo[1]);
                    int indexNumber = int.Parse(commandInfo[2]);
                    inputs.Insert(indexNumber, number);
                    isChange = true;

                }
                else if (commandInfo[0] == "Contains")
                {
                    int number = int.Parse(commandInfo[1]);

                    bool containsNumber = inputs.Contains(number);
                    if (containsNumber)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (commandInfo[0] == "PrintEven")
                {
                    List<int> evenNumbers = inputs.Where(x => x % 2 == 0).ToList();
                    Console.WriteLine(String.Join(' ', evenNumbers));
                }
                else if (commandInfo[0] == "PrintOdd")
                {
                    List<int> oddNumbers = inputs.Where(x => x % 2 != 0).ToList();
                    Console.WriteLine(String.Join(' ', oddNumbers));
                }
                else if (commandInfo[0] == "GetSum")
                {
                    int sumOfNumbers = inputs.Sum();
                    Console.WriteLine(sumOfNumbers);
                }
                else if (commandInfo[0] == "Filter")
                {

                    int number = int.Parse(commandInfo[2]);

                    if (commandInfo[1] == "<")
                    {
                        List<int> smaller = inputs.Where(x => x < number).ToList();
                        Console.WriteLine(String.Join(' ', smaller));
                    }
                    else if (commandInfo[1] == ">")
                    {
                        List<int> bigger = inputs.Where(x => x > number).ToList();
                        Console.WriteLine(String.Join(' ', bigger));
                    }
                    else if (commandInfo[1] == ">=")
                    {
                        List<int> biggerThan = inputs.Where(x => x >= number).ToList();
                        Console.WriteLine(String.Join(' ', biggerThan));
                    }
                    else if (commandInfo[1] == "<=")
                    {
                        List<int> smallerThan = inputs.Where(x => x <= number).ToList();
                        Console.WriteLine(String.Join(' ', smallerThan));
                    }

                }


                command = Console.ReadLine();
            }
            if (isChange)
            {
                Console.WriteLine(String.Join(' ', inputs));

            }
        }
    }
}
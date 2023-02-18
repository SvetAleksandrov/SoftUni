namespace _1._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();   
           
            while (command!= "end")
            {
                string[] comArg = command.Split();

                if (comArg[0] == "Add")
                {
                    int passengers = int.Parse(comArg[1]);
                    wagons.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(comArg[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= maxCapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(' ', wagons));
        }
    }
}
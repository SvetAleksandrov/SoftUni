namespace _6._List_Manipulation_Basics
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

            while (command != "end")
            {
                string[] commandInfo = command.Split();

                if (commandInfo[0] == "Add")
                {
                    int number = int.Parse(commandInfo[1]);
                    inputs.Add(number);
                    //   Console.WriteLine(String.Join(' ', inputs));
                }
                else if (commandInfo[0] == "Remove")
                {
                    int number = int.Parse(commandInfo[1]);
                    inputs.Remove(number);
                    //  Console.WriteLine(String.Join(' ', inputs));
                }
                else if (commandInfo[0] == "RemoveAt")
                {
                    int number = int.Parse(commandInfo[1]);
                    inputs.RemoveAt(number);
                    //  Console.WriteLine(String.Join(' ', inputs));
                }
                else if (commandInfo[0] == "Insert")
                {
                    int number = int.Parse(commandInfo[1]);
                    int indexNumber = int.Parse(commandInfo[2]);
                    inputs.Insert(indexNumber, number);
                    //Console.WriteLine(String.Join(' ', inputs));
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(' ', inputs));
        }
    }
}
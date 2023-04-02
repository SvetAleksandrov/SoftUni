namespace _01._String_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string inputCommands = string.Empty;
            while ((inputCommands = Console.ReadLine()) != "Done")
            {
                string[] commands = inputCommands.Split();

                if (commands[0] == "Change")
                {
                    message = message.Replace(commands[1], commands[2]);
                    Console.WriteLine(message);
                }
                else if (commands[0] == "Includes")
                {
                    if (message.Contains(commands[1]))
                    {
                        Console.WriteLine("True");
                        continue;
                    }
                    Console.WriteLine("False");
                }
                else if (commands[0] == "End")
                {
                    if (message.EndsWith(commands[1]))
                    {
                        Console.WriteLine("True");
                        continue;
                    }
                    Console.WriteLine("False");
                }
                else if (commands[0] == "Uppercase")
                {
                    message = message.ToUpper();
                    Console.WriteLine(message);
                }
                else if (commands[0] == "FindIndex")
                {
                    Console.WriteLine(message.IndexOf(commands[1]));
                }
                else if (commands[0] == "Cut")
                {
                    int startIndex = int.Parse(commands[1]);
                    int count = int.Parse(commands[2]);
                    Console.WriteLine(message.Substring(startIndex, count));
                    message = message.Remove(startIndex, count - 1);
                }
            }

        }
    }
}
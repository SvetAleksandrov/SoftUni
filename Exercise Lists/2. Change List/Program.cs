namespace _2._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] comArg = command.Split();

                if (comArg[0] == "Delete")
                {
                    int element = int.Parse(comArg[1]);
                    numbers.RemoveAll(x => x == element);
                }
                else if (comArg[0] == "Insert")
                {
                    int element = int.Parse(comArg[1]);
                    int position = int.Parse(comArg[2]);

                    numbers.Insert(position, element);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(' ', numbers));
        }
    }
}
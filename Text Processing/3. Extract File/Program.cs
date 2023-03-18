namespace _3._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\", StringSplitOptions.RemoveEmptyEntries);

            string file = input[input.Length - 1];

            string[] subtracts = file.Split(".", StringSplitOptions.RemoveEmptyEntries);


            string name = subtracts[0];
            string type = subtracts[1];

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {type}");

        }
    }
}
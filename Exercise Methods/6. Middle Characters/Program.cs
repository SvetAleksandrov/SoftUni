namespace _6._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintInput(input);
        }
        static void PrintInput(string input)
        {
            if (input.Length % 2 != 0)
            {
                int oddString = (input.Length + 1) / 2;
                Console.WriteLine(input[oddString - 1]);
            }
            else
            {
                int middle = input.Length / 2;
                string output = input.Substring(middle - 1, 2);
                Console.WriteLine(output);
            }
        }
    }
}
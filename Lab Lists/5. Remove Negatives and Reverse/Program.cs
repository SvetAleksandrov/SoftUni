namespace _5._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            input.RemoveAll(x => x < 0);
            input.Reverse();

            if (input.Count > 0)
            {
                Console.WriteLine(String.Join (' ', input));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
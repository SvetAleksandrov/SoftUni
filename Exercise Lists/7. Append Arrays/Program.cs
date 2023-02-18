namespace _7._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrays = input.Split('|', StringSplitOptions.RemoveEmptyEntries);

            List<int> result = new List<int>();

            for (int i = arrays.Length - 1; i >= 0; i--)
            {
                int[] currentArray = arrays[i]
              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                result.AddRange(currentArray);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
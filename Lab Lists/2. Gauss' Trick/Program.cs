namespace _2._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int originalLenth = numbers.Count;

            for (int i = 0; i < originalLenth/2; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count-1);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
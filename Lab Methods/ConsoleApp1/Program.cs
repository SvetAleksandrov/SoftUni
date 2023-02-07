namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Triangle(n);
        }

        static void PrinLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void Triangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                PrinLine(1, i);
            }
            for (int i = number-1; i >= 1; i--)
            {
                PrinLine(1, i);
            }
        }
    }
}
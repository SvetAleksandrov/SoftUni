namespace _1._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            CheckTheNumber(number);
        }

        static void CheckTheNumber(int currentNumber)
        {

            if (currentNumber > 0)
            {
                Console.WriteLine($"The number {currentNumber} is positive.");
            }
            else if (currentNumber < 0)
            {
                Console.WriteLine($"The number {currentNumber} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {currentNumber} is zero.");
            }
        }
    }
}
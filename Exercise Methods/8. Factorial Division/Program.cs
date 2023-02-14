namespace _8._Factorial_Division

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            Calculation(numberOne, numberTwo);
        }
        static void Calculation(int numberOne, int numberTwo)
        {
            double factorialNumberOne = 1;
            for (int i = 0; i < numberOne; i++)
            {
                factorialNumberOne *= i + 1;
            }

            double factorialNumberTwo = 1;

            for (int i = 0; i < numberTwo; i++)
            {
                factorialNumberTwo *= i + 1;
            }

            double result = factorialNumberOne / factorialNumberTwo;

            Console.WriteLine("{0:f2}", result);

        }
    }
}
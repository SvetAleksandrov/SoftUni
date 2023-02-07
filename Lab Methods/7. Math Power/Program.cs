namespace _7._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double result = Calculation(firstNumber, secondNumber);
            Console.WriteLine(result);

        }

        static double Calculation(double bases, double power)
        {
            double result = Math.Pow(bases, power);

            return result;
        }
    }
}
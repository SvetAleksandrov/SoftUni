using System.Xml.Schema;

namespace _5._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            Console.WriteLine(Subtracts(SumOfTwoInteger(numberOne, numberTwo), numberThree));

        }

        static int SumOfTwoInteger(int numberOne, int numberTwo)
        {
            int sum = numberOne + numberTwo;

            return sum;
        }

        static int Subtracts(int SumOfTwoInteger, int b)
        {
            int total = SumOfTwoInteger - b;
            return total;
        }
    }
}
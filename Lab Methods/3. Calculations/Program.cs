using System.Diagnostics;
using System.Linq.Expressions;

namespace _3._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            switch (comand)
            {
                case "add":
                    AddNumbers(numberOne, numberTwo);
                    break;
                case "multiply":
                    MultiplyNumbers(numberOne, numberTwo);
                    break;
                case "subtract":
                    SubtractNumbers(numberOne, numberTwo);
                    break;
                case "divide":
                    DivideNumbers(numberOne, numberTwo);
                    break;
            }

        }
        static void AddNumbers(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void MultiplyNumbers(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void SubtractNumbers(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void DivideNumbers(int a, int b)
        {
            Console.WriteLine(a / b);
        }

    }
}
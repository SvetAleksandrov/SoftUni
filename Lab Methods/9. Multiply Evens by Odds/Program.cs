using System;
using System.Reflection;

namespace _9._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            Operation(numberOne, symbol, numberTwo);

        }
        static void Operation(double numberOne, char symbol, double numberTwo)
        {
            //char[] operations = { '/', '*', '+', '-' };

            //char index = (char)Array.IndexOf(operations, symbol);


            switch (symbol)
            {
                case '+':
                    Console.WriteLine(numberOne + numberTwo);
                    break;
                case '-':
                    Console.WriteLine(numberOne - numberTwo);
                    break;
                case '*':
                    Console.WriteLine(numberOne * numberTwo);
                    break;
                case '/':
                    Console.WriteLine(numberOne / numberTwo);
                    break;
            }


        }
    }
}

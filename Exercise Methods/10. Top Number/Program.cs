using System.Reflection.Metadata.Ecma335;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i <= inputNumber; i++)
            {
                if (DigitIsDivideBy8(i) == true && OddsDigit(i) == true)
                {
                    Console.WriteLine(i);
                }
            }


        }
        static bool DigitIsDivideBy8(int number)
        {
            int sumOfDigits = 0;
            while (number > 0)
            {
                sumOfDigits += number % 10;
                number /= 10;
            }
            if (sumOfDigits % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool OddsDigit(int number)
        {
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }

    }
}
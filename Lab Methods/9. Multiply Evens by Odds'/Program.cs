using System.Collections.Generic;

namespace _9._Multiply_Evens_by_Odds_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int result = GetSumOfEvenDigits(Math.Abs(input)) * GetSumOfOddDigits(Math.Abs(input));
            Console.WriteLine(result);
        }

        //static void GetMultipleOfEvenAndOdds(int input)
        //{
        //    int originalInput = input;
        //    int evenNumber = 0;
        //    int oddNumber = 0;

        //    while (input > 0)
        //    {
        //        int lastDigit = input % 10;
        //        if (lastDigit % 2 == 0)
        //        {
        //            evenNumber = evenNumber * 10 + lastDigit;
        //        }
        //        else if (lastDigit % 2 != 0)
        //        {
        //            oddNumber = oddNumber * 10 + lastDigit;
        //        }
        //        input /= 10;
        //    }
        //}
        static int GetSumOfEvenDigits(int evenNumber)
        {
            int currentEvenSum = 0;

            while (evenNumber > 0)
            {
                int lastDigit = evenNumber % 10;
                if (lastDigit % 2 == 0)
                {
                    currentEvenSum += lastDigit;
                }
                evenNumber /= 10;
            }

            return currentEvenSum;
        }

        static int GetSumOfOddDigits(int oddNumber)
        {
            int currentOddSum = 0;

            while (oddNumber > 0)
            {
                int lastDigit = oddNumber % 10;
                if (lastDigit % 2 != 0)
                {
                    currentOddSum += lastDigit;
                }
                oddNumber /= 10;
            }
            return currentOddSum;
        }
    }
}


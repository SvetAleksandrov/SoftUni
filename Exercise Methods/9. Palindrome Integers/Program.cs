namespace _9._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                int number = int.Parse(input);
                if (number<1)
                {
                    break;
                }
                PalindromeNumber(number);
                input = Console.ReadLine();
            }
        }
        static void PalindromeNumber(int number)
        {
            int reverseNumber = 0;
            int originalNumber = number;

            while (number > 0)
            {
                int lastDigit = number % 10;
                reverseNumber = (reverseNumber * 10) + lastDigit;
                number /= 10;
            }

            if (originalNumber == reverseNumber)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}

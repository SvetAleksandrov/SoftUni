namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string digits = string.Empty;
            string letters = string.Empty;
            string other = string.Empty;

            foreach (char c in input)
            {
                if (Char.IsDigit(c))
                {
                    digits += c;
                }
                else if (Char.IsLetter(c))
                {
                    letters += c;
                }
                else
                {
                    other += c;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}
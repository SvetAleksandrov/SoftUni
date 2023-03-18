using System.Text;

namespace _5._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int multiply = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            int reminder = 0;

            if (multiply == 0 || numbers == "0")
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(numbers[i].ToString());
                int product = currentDigit * multiply + reminder;
                int result = product % 10;
                reminder = product / 10;
                sb.Insert(0, result);
            }

            if (reminder > 0)
            {
                sb.Insert(0, reminder);
            }
            Console.WriteLine(sb.ToString());



        }
    }
}
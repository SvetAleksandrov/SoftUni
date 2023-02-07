using System;

namespace _8._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int, char and string
            string type = Console.ReadLine();

            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                int result = GetMax(a, b);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());

                char result = GetMax(a, b);
                Console.WriteLine(result);
            }
            else
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();

                string result = GetMax(a, b);
                Console.WriteLine(result);
            }
        }

        static int GetMax(int a, int b)
        {
            int max = Math.Max(a, b);

            return max;
        }
        static char GetMax(char a, char b)
        {
            char max = (char)Math.Max(a, b);

            return max;
        }
        static string GetMax(string a, string b)
        {
            string max = string.Compare(a, b) > 0 ? a : b;

            return max;
        }
    }
}
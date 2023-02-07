using System.Runtime.CompilerServices;

namespace _7._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rotations = int.Parse(Console.ReadLine());

            string result = RotationString(input, rotations);

            Console.WriteLine(result);
        }

        static string RotationString(string input, int rotations)
        {

            string result = "";

            for (int i = 0; i < rotations; i++)
            {
                result += input;
            }

            return result;
        }
    }
}
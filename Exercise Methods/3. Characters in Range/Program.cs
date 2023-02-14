namespace _3._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char inputOne = char.Parse(Console.ReadLine());
            char inputTwo = char.Parse(Console.ReadLine());

            PrintingAsciNumber(inputOne, inputTwo);
        }
        static void PrintingAsciNumber(char one, char two)
        {
            if (two < one)
            {
                char temp = one;
                one = two;
                two = temp;
            }

            one++;

            for (char i = one; i < two; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
namespace _1._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int minNumber = PrintingNumbers(firstNumber, secondNumber, thirdNumber);


            Console.WriteLine(minNumber);
        }

        static int PrintingNumbers(int one, int two, int three)
        {
            int minNumber = Math.Min(Math.Min(one, two), three);

            return minNumber;
        }
    }

}
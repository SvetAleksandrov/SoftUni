namespace _8._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input:A12b s17G   Output: 330


            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double result = 0;

            foreach (string str in input)
            {
                char firstLetter = str[0];
                char lastLetter = str[^1];

                string middleChars = str[1..^1];

                double middleValue = double.Parse(middleChars);

                if (char.IsUpper(firstLetter))
                {
                    int postionLetter = firstLetter - 64;
                    middleValue /= postionLetter;
                }
                else 
                {
                    int postionLetter = firstLetter - 96;
                    middleValue *= postionLetter;
                }

                if (char.IsUpper(lastLetter))
                {
                    int postionLetter = lastLetter - 64;
                    middleValue -= postionLetter;
                }
                else 
                {
                    int postionLetter = lastLetter - 96;
                    middleValue += postionLetter;
                }
                result += middleValue;
            }
            
            Console.WriteLine($"{result:f2}");

        }
    }
}
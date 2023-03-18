namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            GetSum(input[0], input[1]);
        }

        private static void GetSum(string letterOne, string letterTwo)
        {
            //{
            //    int sum = 0;
            //    int minLength = Math.Min(stringOne.Length, stringTwo.Length);
            //    for (int i = 0; i < minLength; i++)
            //    {
            //        sum += stringOne[i] * stringTwo[i];
            //    }

            //    string longestLegthString = stringOne;
            //    if (longestLegthString.Length < stringTwo.Length)
            //    {
            //        longestLegthString = stringTwo;
            //    }
            //    for (int i = minLength; i < longestLegthString.Length; i++)
            //    {
            //        sum += longestLegthString[i];
            //    }
            //    Console.WriteLine(sum);
            //}

            int sum = 0;
            int minLength = Math.Min(letterOne.Length, letterTwo.Length);

            for (int i = 0; i < minLength; i++)
            {
                sum += letterOne[i] * letterTwo[i];
            }

            string longestString = letterOne;

            if (longestString.Length < letterTwo.Length)
            {
                longestString = letterTwo;
            }
            for (int i = minLength; i < longestString.Length; i++)
            {
                sum += longestString[i];
            }

            Console.WriteLine(sum);



        }
    }
}
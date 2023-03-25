using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[+][359]+ [2] [0-9]{3} [0-9]{4}|[+][359]+-[2]-[0-9]{3}-[0-9]{4}\b";

            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Ma(input, pattern);

            List<string> matchedValues = new List<string>();


            foreach (Match match in matches)
            {
                matchedValues.Add(match.Value);
            }
            Console.WriteLine(String.Join(", ", matchedValues));
        }
    }
}

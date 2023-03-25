using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which matches a date in the format "dd{separator}MMM{separator}yyyy".
            //Use named capturing groups in your regular expression.

            string pattern = @"\b(?<day>\d{2})([/|\-|.])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            //string pattern @"\b(?<day>\d{2})([\/\-\.])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b";


            string input = Console.ReadLine();

            Regex regex= new Regex(pattern);

            MatchCollection match= regex.Matches(input);

            foreach (Match date in match)
            {
                Console.WriteLine($"Day: {date.Groups["day"]}, Month: {date.Groups["month"]}, Year: {date.Groups["year"]}");
            }

        }
    }
}
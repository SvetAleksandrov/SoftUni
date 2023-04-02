using System.Diagnostics.SymbolStore;
using System.Text.RegularExpressions;

namespace Problem_2___Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\=|\/)(?<country>[A-Z][A-Za-z]{2,})\1";

            string input = Console.ReadLine();

            int sum = 0;
            Regex regex = new Regex(pattern);

            MatchCollection match = regex.Matches(input);

            foreach (Match country in match)
            {
                int length = country.Groups["country"].Length;
                sum += length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", match.Select(m => m.Groups["country"].Value))}");
            Console.WriteLine($"Travel Points: {sum}");
        }
    }
}
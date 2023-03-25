using System.Text;
using System.Text.RegularExpressions;

namespace _2._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> racers = new Dictionary<string, int>();

            foreach (var participant in participants)
            {
                racers[participant] = 0;
            }

            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                string namePattern = @"[A-Za-z]";
                string distancePattern = @"\d";

                MatchCollection nameMatches = Regex.Matches(input, namePattern);
                MatchCollection distanceMatches = Regex.Matches(input, distancePattern);

                StringBuilder names = new StringBuilder();
                foreach (Match match in nameMatches)
                {
                    names.Append(match.Value);
                }
                string name = names.ToString();

                int distance = distanceMatches.Sum(x => int.Parse(x.Value));

                if (racers.ContainsKey(name))
                {
                    racers[name] += distance;
                }
            }

            var topRacers = racers.OrderByDescending(r => r.Value).Take(3).ToList();

            Console.WriteLine($"1st place: {topRacers[0].Key}");
            Console.WriteLine($"2nd place: {topRacers[1].Key}");
            Console.WriteLine($"3rd place: {topRacers[2].Key}");
        }
    }
}

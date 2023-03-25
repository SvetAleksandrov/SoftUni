using System.Text.RegularExpressions;

namespace _3._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^\%(?<customer>[A-Z][a-z]+)\%[^\%\|\$\.]*?\<(?<product>\w+)\>[^\%\|\$\.]*?\|(?<count>\d+)\|[^\%\|\$\.]*?(?<price>\d+(\.\d+)?)\$[^\%\|\$\.]*?$";

            Regex regex = new Regex(pattern);
            string input;
            double totalPrice = 0;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    double result = count * price;
                    Console.WriteLine($"{customer}: {product} - {result:f2}");
                    totalPrice+= result;
                }

            }
            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}
using System.Drawing;
using System.Text.RegularExpressions;

namespace _1._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program to calculate the total cost of different types of furniture. You will be given some lines of input, until you receive the line "Purchase". For the line to be valid it should be in the following format:
            //">>{furniture name}<<{price}!{quantity}
            //The price can be a floating-point number or a whole number.Store the names of the furniture and the total price. At the end, print each bought furniture on a separate line in the format:
            //"Bought furniture:
            //{ 1st name}
            //{ 2nd name}

            string pattern = @"^>>(?<furniture>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)(\.\d+)?$";
                               

            Regex regex = new Regex(pattern);
            List<string> furniture = new List<string>();
            double totalMoneySpend = 0;

            string input;

            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string furnitureName = match.Groups["furniture"].Value;
                    double pricePerUnit = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    furniture.Add(furnitureName);
                    totalMoneySpend += pricePerUnit * quantity;
                }

            }
            Console.WriteLine($"Bought furniture:");
            foreach (var furnitureName in furniture)
            {
                Console.WriteLine(furnitureName);
            }
            Console.WriteLine($"Total money spend: {totalMoneySpend:f2}");
        }
    }
}
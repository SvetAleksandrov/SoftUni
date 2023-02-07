using System.ComponentModel;
using System.Xml.Schema;

namespace _5._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double result = TotalCost(product, quantity);

            Console.WriteLine($"{result:f2}");
        }
        static double TotalCost(string product, double quantity)
        {
            string[] products = { "coffee", "water", "coke", "snacks" };
            double[] prices = { 1.50, 1.00, 1.40, 2.00 };

            int index = Array.IndexOf(products, product);

            return prices[index] * quantity;
        }
    }
}
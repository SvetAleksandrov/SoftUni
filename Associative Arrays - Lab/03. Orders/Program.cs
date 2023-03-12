using System.Linq;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            Dictionary<double, int> formula = new Dictionary<double, int>();
            Dictionary<string, (double price, int quantity)> product = new Dictionary<string, (double price, int quantity)>();



            while ((command = Console.ReadLine()) != "buy")
            {

                string[] cmdArg = command
                    .Split(" ");

                //"{name} {price} {quantity}"

                string productName = cmdArg[0];
                double price = double.Parse(cmdArg[1]);
                int quantity = int.Parse(cmdArg[2]);


                if (!product.ContainsKey(productName))
                {
                    product.Add(productName, (price, quantity));
                }
                else
                {
                    int totalQuantity = product[productName].quantity + quantity;
                    product[productName] = (price, totalQuantity);
                }

            }

            foreach (var item in product)
            {
                //"{productName} -> {totalPrice}"
                string productName = item.Key;
                double price = item.Value.price;
                int quantity = item.Value.quantity;
                double totalPrice = price * quantity;

                Console.WriteLine($"{productName} -> {totalPrice:F2}");
            }
        }
    }
}
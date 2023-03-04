namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            List<Box> items = new List<Box>();

            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArgument = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string serialNumber = commandArgument[0];
                string itemName = commandArgument[1];
                int itemQuantity = int.Parse(commandArgument[2]);
                double itemPrice = double.Parse(commandArgument[3]);

                Item newItem = new Item();
                newItem.Name = itemName;
                newItem.Price = itemPrice;


                Box box = new Box();
                box.SerialNumber = serialNumber;
                box.Item = newItem;
                box.ItemQuantity = itemQuantity;
                items.Add(box);
            }

            List<Box> filterList = items
                .OrderByDescending(x => x.PricePerBox)
                .ToList();

            foreach (Box box in filterList)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PricePerBox:F2}");
            }


        }
    }
}

class Item
{
    public string Name { get; set; }

    public double Price { get; set; }
}

class Box
{
    public string SerialNumber { get; set; }

    public Item Item { get; set; }

    public int ItemQuantity { get; set; }

    public double PricePerBox { get { return ItemQuantity * Item.Price; } }
}
namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            List<Catalog> catalogs = new List<Catalog>();

            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArguments = command
                    .Split("/", StringSplitOptions.RemoveEmptyEntries);

                //"{type}/{brand}/{model}/{horse power / weight}"

                string type = commandArguments[0];
                string brand = commandArguments[1];
                string model = commandArguments[2];
                int power = int.Parse(commandArguments[3]);

                if (type == "Car")
                {
                    Car newCar = new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = power,
                    };
                    cars.Add(newCar);
                }
                else if (type == "Truck")
                {
                    Truck newTruck = new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = power,
                    };
                    trucks.Add(newTruck);
                }
            }

            Catalog newCatalog = new Catalog
            {
                Cars = cars,
                Trucks = trucks,
            };
            newCatalog.PrintCatalog();
        }
    }

    class Truck // Brand, Model, and Weight.
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }

    }

    class Car //Brand, Model, and Horse Power
    {
        public string Brand { set; get; }

        public string Model { set; get; }

        public int HorsePower { set; get; }
    }

    class Catalog
    {
        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }

        public void PrintCatalog()
        {
            Console.WriteLine("Cars:");
            foreach (Car car in Cars.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            Console.WriteLine("Truck:");
            foreach (Truck truck in Trucks.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }

    }
}
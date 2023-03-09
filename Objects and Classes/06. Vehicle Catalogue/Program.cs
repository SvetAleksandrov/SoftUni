namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] vehicleArgs = input.Split();
                string type = vehicleArgs[0];
                string model = vehicleArgs[1];
                string color = vehicleArgs[2];
                int horsepower = int.Parse(vehicleArgs[3]);

                Vehicle vehicle = new Vehicle(type, model, color, horsepower);
                vehicles.Add(vehicle);
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Close the Catalogue")
                {
                    break;
                }

                Vehicle vehicle = vehicles.FirstOrDefault(v => v.Model == input);
                Console.WriteLine($"Type: {vehicle.Type.Substring(0, 1).ToUpper()}{vehicle.Type.Substring(1)}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Color: {vehicle.Color}");
                Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
            }

            double carsAvgHorsepower = vehicles.Where(v => v.Type == "car").Average(v => v.Horsepower);
            double trucksAvgHorsepower = vehicles.Where(v => v.Type == "truck").Average(v => v.Horsepower);

            Console.WriteLine($"Cars have average horsepower of: {carsAvgHorsepower:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAvgHorsepower:F2}.");
        }
    }
}
class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public Vehicle(string type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }
    }
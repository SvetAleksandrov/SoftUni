namespace Problem_3___Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                string[] inputCars = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
                            
                cars.Add(inputCars[0], new Car(int.Parse(inputCars[1]), int.Parse(inputCars[2])));
            }

            string commandInput;

            while ((commandInput = Console.ReadLine()) != "Stop")
            {
                string[] commandInfo = commandInput.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string commands = commandInfo[0];

                if (commands == "Drive") //{car} : {distance} : {fuel}
                {
                    string car = commandInfo[1];
                    int distance = int.Parse(commandInfo[2]);
                    int desireFuel = int.Parse(commandInfo[3]);


                    if (cars[car].Fuel < desireFuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        cars[car].Mileage += distance;
                        cars[car].Fuel -= desireFuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {desireFuel} liters of fuel consumed.");

                        if (cars[car].Mileage >= 10_000)
                        {
                            cars.Remove(car);
                            Console.WriteLine($"Time to sell the {car}!");
                            
                        }
                    }
                }
                else if (commands == "Refuel") //: {car} : {fuel}
                {
                    string car = commandInfo[1];
                    int fuel = int.Parse(commandInfo[2]);

                    if (cars[car].Fuel + fuel > 75)
                    {
                        fuel = 75 - cars[car].Fuel;
                    }
                    cars[car].Fuel += fuel;
                    Console.WriteLine($"{car} refueled with {fuel} liters");


                }
                else if (commands == "Revert") // : {car} : {kilometers}
                {
                    string car = commandInfo[1];
                    int kilometers = int.Parse(commandInfo[2]);
                                     

                    if (cars[car].Mileage - kilometers > 10_000)
                    {
                        cars[car].Mileage -= kilometers;
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                        return;
                    }
                }

                //"{car} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt."

                foreach (var car in cars)
                {
                    Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Mileage} kms, Fuel in the tank: {car.Value.Fuel} lt.");
                }

            }
        }
    }
}



class Car
{
    public Car(int mileage, int fuel)
    {
        Mileage = mileage;
        Fuel = fuel;
    }

    public int Mileage { get; set; }

    public int Fuel { get; set; }

}
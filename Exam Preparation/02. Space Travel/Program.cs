namespace Space_Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] route = Console.ReadLine().Split(new string[] { "||" }, StringSplitOptions.RemoveEmptyEntries);
            int fuel = int.Parse(Console.ReadLine());
            int ammo = int.Parse(Console.ReadLine());

            for (int i = 0; i < route.Length; i++)
            {
                string[] command = route[i]
                    .Split(' ');

                string action = command[0];

                int value = 0;
                if (command.Length > 1)
                {
                    int.TryParse(command[1], out value);
                }

                switch (action)
                {
                    case "Travel":
                        if (fuel >= value)
                        {
                            fuel -= value;
                            Console.WriteLine($"The spaceship travelled {value} light-years.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }
                        break;

                    case "Enemy":
                        int ammoNeeded = value;
                        if (ammo >= ammoNeeded)
                        {
                            ammo -= ammoNeeded;
                            Console.WriteLine($"An enemy with {value} armour is defeated.");
                        }
                        else
                        {
                            int distance = value * 2;
                            if (fuel >= distance)
                            {
                                fuel -= distance;
                                Console.WriteLine($"An enemy with {value} armour is outmaneuvered.");
                            }
                            else
                            {
                                Console.WriteLine("Mission failed.");
                                return;
                            }
                        }
                        break;

                    case "Repair":
                        ammo += value * 2;
                        fuel += value;
                        Console.WriteLine($"Ammunitions added: {value * 2}.");
                        Console.WriteLine($"Fuel added: {value}.");
                        break;

                    case "Titan":
                        Console.WriteLine("You have reached Titan, all passengers are safe.");
                        return;

                    default:
                        break;
                }
            }
        }
    }
}
namespace _4._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> parkingList = new Dictionary<string, string>();


            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string actions = command[0];
                string username = command[1];

                if (actions == "register")
                {
                    string licensePlateNumber = command[2];

                    if (!parkingList.ContainsKey(username))
                    {
                        parkingList[username] = licensePlateNumber;
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                }
                else if (actions == "unregister")
                {
                    if (!parkingList.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        parkingList.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }
            foreach (var item in parkingList)
            {
                //"{username} => {licensePlateNumber}"
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}

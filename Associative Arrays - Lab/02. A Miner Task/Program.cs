namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;


            Dictionary<string, int> jewery = new Dictionary<string, int>();

            while ((command = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!jewery.ContainsKey(command))
                {
                    jewery.Add(command, 0);
                }

                jewery[command] += quantity;
            }

            foreach (var item in jewery)
            {
                //"{resource} –> {quantity}"

                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

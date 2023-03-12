namespace _7._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();

            while ((command = Console.ReadLine()) != "End")
            {
                //receiving input in the format: "{companyName} -> {employeeId}".

                string[] cmdType = command
                    .Split(" -> ");

                string comanyName = cmdType[0];
                string employeeId = cmdType[1];

                if (!companyUsers.ContainsKey(comanyName))
                {
                    companyUsers[comanyName] = new List<string>();
                }

                if (!companyUsers[comanyName].Contains(employeeId))
                {
                    companyUsers[comanyName].Add(employeeId);
                }
            }
            foreach (var item in companyUsers)
            {
                //{companyName}
                //-- { id1}
                //-- { id2}
                //-- { idN}
                Console.WriteLine($"{item.Key}");
                foreach (string id in item.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
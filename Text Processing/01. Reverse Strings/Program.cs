namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            string reversWord = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                reversWord = new string(command.Reverse().ToArray());
                Console.WriteLine($"{command} = {reversWord}");
            }
            //Console.WriteLine($"{command} = {reversWord}");
        }

    }
}
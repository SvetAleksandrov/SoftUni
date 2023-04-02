using System.Linq;

namespace _01._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string input;

            while ((input = Console.ReadLine()) != "Done")
            {

                string[] cmdArg = input.Split();

                string cmdActions = cmdArg[0];

                if (cmdActions == "TakeOdd")
                {
                    string resultString = new string(password.Where((c, i) => i % 2 == 1).ToArray());
                    password = resultString;

                    Console.WriteLine(password);
                }
                else if (cmdActions == "Cut")
                {
                    int index = int.Parse(cmdArg[1]);
                    int lenght = int.Parse(cmdArg[2]);

                    string substringToCut = password.Substring(index, lenght);

                    int indexOfSubstring = password.IndexOf(substringToCut);

                    if (indexOfSubstring != -1)
                    {
                        password = password.Remove(indexOfSubstring, lenght);
                    }
                    Console.WriteLine(password);


                }
                else if (cmdActions == "Substitute")
                {
                    string substring = cmdArg[1];
                    string substitute = cmdArg[2];

                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }


            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
using System;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] cmdArgs = command.Split(">>>");

                string cmdType = cmdArgs[0];

                if (cmdType == "Contains")
                {
                    string substring = cmdArgs[1];

                    if (rawActivationKey.Contains(substring))
                    {
                        Console.WriteLine($"{rawActivationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (cmdType == "Flip")
                {
                    string caseType = cmdArgs[1];
                    int startIndex = int.Parse(cmdArgs[2]);
                    int endIndex = int.Parse(cmdArgs[3]);

                    string substring = rawActivationKey.Substring(startIndex, endIndex - startIndex);

                    if (caseType == "Upper")
                    {
                        substring = substring.ToUpper();
                    }
                    else if (caseType == "Lower")
                    {
                        substring = substring.ToLower();
                    }

                    rawActivationKey = rawActivationKey.Substring(0, startIndex) + substring + rawActivationKey.Substring(endIndex);

                    Console.WriteLine(rawActivationKey);
                }
                else if (cmdType == "Slice")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);

                    Console.WriteLine(rawActivationKey);
                }
            }

            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }
    }
}

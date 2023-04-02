using System.Collections.Generic;

namespace Problem_1___The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zzHe - first line
            //ChangeAll | z | l
            //Insert | 2 | o
            //Move | 3
            //Decode - end

            string encryptedMessage = Console.ReadLine();

            string input;

            while ((input = Console.ReadLine()) != "Decode")
            {
                string[] operations = input
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string actions = operations[0];

                if (actions == "Move")
                {
                    int numberOfLetters = int.Parse(operations[1]);
                    encryptedMessage = encryptedMessage.Substring(numberOfLetters) + encryptedMessage.Substring(0, numberOfLetters);
                }
                else if (actions == "Insert") //"Insert {index} {value}":
                {
                    int index = int.Parse(operations[1]);  
                    string value = operations[2];

                    encryptedMessage = encryptedMessage.Insert(index, value);
                }
                else if (actions == "ChangeAll") //ChangeAll {substring} {replacement}":
                {
                    string substring = operations[1];
                    string replacement = operations[2];

                    encryptedMessage = encryptedMessage.Replace(substring, replacement);
                }
            }

            Console.WriteLine($"The decrypted message is: {encryptedMessage}");


        }
    }
}
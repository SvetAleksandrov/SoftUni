using System;

namespace _4._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string paswrod = Console.ReadLine();

            if (CharactersCheck(paswrod) == true && AlphabetAndDigitCheck(paswrod) == true && AtLeastTwoDigtitCheck(paswrod) == true)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!CharactersCheck(paswrod))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!AlphabetAndDigitCheck(paswrod))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!AtLeastTwoDigtitCheck(paswrod))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }


        }

        static bool CharactersCheck(string inputPassword)
        {
            if (inputPassword.Length < 6 || inputPassword.Length > 10)
            {
                // Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
            return true;
        }
        static bool AlphabetAndDigitCheck(string inputPassword)
        {
            foreach (char item in inputPassword)
            {
                if (!char.IsLetterOrDigit(item))
                {
                    return false;
                }
            }
            return true;
        }
        static bool AtLeastTwoDigtitCheck(string inputPassword)
        {
            int countDigit = 0;

            foreach (var item in inputPassword)
            {
                if (char.IsDigit(item))
                {
                    countDigit++;
                }
            }
            if (countDigit < 2)
            {
                return false;
            }
            return true;
        }
    }
}

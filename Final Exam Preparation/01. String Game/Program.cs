namespace _01._String_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string inputCommands = string.Empty;
            while ((inputCommands = Console.ReadLine()) != "Done")
            {
                string[] commands = inputCommands.Split();

                if (commands[0] == "Change")
                {
                    message = message.Replace(commands[1], commands[2]);
                    Console.WriteLine(message);
                }
                else if (commands[0] == "Includes")
                {
                    if (message.Contains(commands[1]))
                    {
                        Console.WriteLine("True");
                        continue;
                    }
                    Console.WriteLine("False");
                }
                else if (commands[0] == "End")
                {
                    //В този блок код се използва методът EndsWith на низовата променлива message, който приема като аргумент низа, подаден на командата.
                    //Ако message завършва с този низ, методът връща true, иначе връща false.
                    //Като резултат на това проверка се извежда на конзолата "True" или "False".
                    if (message.EndsWith(commands[1]))
                    {
                        Console.WriteLine("True");
                        continue;
                    }
                    Console.WriteLine("False");
                }
                else if (commands[0] == "Uppercase")
                {
                    message = message.ToUpper();
                    Console.WriteLine(message);
                }
                else if (commands[0] == "FindIndex")
                {
                    //Този блок код проверява дали първата команда, дадена в конзолата е "FindIndex".
                    //Ако е, тогава се търси индексът на дума, която се въвежда като втори аргумент.
                    //Това става с помощта на метода IndexOf().
                    //Този метод търси първата позиция на срещане на зададената дума в message и връща този индекс. Този индекс се изписва на конзолата.
                    Console.WriteLine(message.IndexOf(commands[1]));
                }
                else if (commands[0] == "Cut")
                {
                    int startIndex = int.Parse(commands[1]);
                    int count = int.Parse(commands[2]);
                    // Тук извеждаме на екрана поредицата от символи, които са изрязани от първоначалната дума.
                    // Това става чрез използване на метода Substring() върху променливата message.
                    // Методът Substring() приема два аргумента - начален индекс и дължина.
                    // Тук използваме индекса и дължината, които сме взели от командата "Cut", за да изрежем поредицата от символи от message.
                    Console.WriteLine(message.Substring(startIndex, count));

                    //Тук изрязваме поредицата от символи от message.
                    //Това става чрез метода Remove(), който приема два аргумента - начален индекс и брой символи за изрязване.
                    //В случая вземаме индекса и дължината, които сме взели от командата "Cut" и използваме тяхната стойност, за да изрежем поредицата от символи от message.
                    //Важно е да се отбележи, че тъй като броят символи за изрязване трябва да бъде равен на дължината, която сме взели от командата "Cut", ние изваждаме 1 от броя символи, за да избегнем изрязването на един символ повече.
                    message = message.Remove(startIndex, count - 1);
                }
            }

        }
    }
}
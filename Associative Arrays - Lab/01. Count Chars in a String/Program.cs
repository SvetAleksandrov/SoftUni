namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();                 

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (c == ' ')
                {
                    continue;
                }

                if (!counts.ContainsKey(c))
                {
                    counts.Add(c, 1);
                }
                else
                {
                    counts[c]++;
                }
            }

            foreach (var key in counts)
            {
                Console.WriteLine($"{key.Key} -> {key.Value}");
            }



        }
    }
}
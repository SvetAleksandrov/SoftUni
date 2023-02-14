namespace _2._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Vowels(input); 
        }

        static void Vowels(string input)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;

            input = input.ToLower();

            foreach (var symbols in input)
            {
                if (vowels.Contains(symbols))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
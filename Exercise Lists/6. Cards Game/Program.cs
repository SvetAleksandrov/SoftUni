using System.ComponentModel;
using System.Xml.Schema;

namespace _6._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> deckOne = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> deckTwo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int countFirstDeck = 0;
            int countSecondDeck = 0;

            int iterations = Math.Min(deckOne.Count, deckTwo.Count);

            while (deckOne.Count > 0 && deckTwo.Count > 0)
            {
                int cardOne = deckOne[0];
                int cardTwo = deckTwo[0];

                if (cardOne > cardTwo)
                {
                    deckOne.RemoveAt(0);
                    deckTwo.RemoveAt(0);
                    deckOne.Add(cardOne);
                    deckOne.Add(cardTwo);
                }
                else if (cardTwo > cardOne)
                {
                    deckOne.RemoveAt(0);
                    deckTwo.RemoveAt(0);
                    deckTwo.Add(cardTwo);
                    deckTwo.Add(cardOne);
                }
                else
                {
                    deckOne.RemoveAt(0);
                    deckTwo.RemoveAt(0);
                }
            }

            List<int> finalDeck = new List<int>(deckOne);

            if (deckTwo.Count > 0)
            {
                finalDeck.AddRange(deckTwo);
            }

            double sum = finalDeck.Sum();

            if (deckOne.Count > deckTwo.Count)
            {
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else if (deckOne.Count < deckTwo.Count)
            {
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}
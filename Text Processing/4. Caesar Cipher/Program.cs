using System.Text;

namespace _4._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //string input = Console.ReadLine(); // Programming is cool!
                //var sb = new StringBuilder();
                //foreach (char currCahr in input)
                //{
                //    int currPositon = currCahr; // currChar = "P" in int => 80
                //    currPositon += 3;
                //    sb.Append((char)currPositon); // 83 int into char => 'S'
                //}
                //Console.WriteLine(sb.ToString());

                string input = Console.ReadLine();  

                var text = new StringBuilder();

                foreach (char currentChar in input)
                {

                    int currentPlace = currentChar;
                    currentPlace += 3;
                    text.Append((char)currentPlace);

                }

                Console.WriteLine(text.ToString());
               
    
            }
        }
    }
}
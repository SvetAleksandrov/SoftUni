namespace _6._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wight = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int areaOfRectangle = Area (wight, height);
            Console.WriteLine(areaOfRectangle);
        }

        static int Area (int wight, int height)
        {
            return wight*height;
        }
    }
}
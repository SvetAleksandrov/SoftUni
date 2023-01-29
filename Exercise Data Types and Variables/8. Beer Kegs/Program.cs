int numberOfLines = int.Parse(Console.ReadLine());

double currentVolumeKegs = 0;
string currentKeg = "";
double maxVolumeKegs = 0;

for (int i = 0; i < numberOfLines; i++)
{
    string modelKegs = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    double heigh = double.Parse(Console.ReadLine());

    currentVolumeKegs = (Math.PI * Math.Pow(radius, 2) * heigh);

    if (currentVolumeKegs >= maxVolumeKegs)
    {
        maxVolumeKegs = currentVolumeKegs;
        currentKeg = modelKegs;
    }
}
Console.WriteLine($"{currentKeg}");
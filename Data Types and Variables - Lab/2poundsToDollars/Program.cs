double britishPounds = double.Parse(Console.ReadLine());

decimal usdConvert = (decimal)(britishPounds * 1.31);

Console.WriteLine($"{usdConvert:F3}");
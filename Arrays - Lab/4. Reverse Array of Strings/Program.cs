string[] input = Console.ReadLine()
    .Split()
    .ToArray();

input = input.Reverse().ToArray();

Console.WriteLine(string.Join(" ",input));


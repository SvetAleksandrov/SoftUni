﻿int input = int.Parse(Console.ReadLine());

int sum = 0;

while (input > 0)
{
    int number = input % 10;
    sum += number;

    input = input / 10;
}

Console.WriteLine(sum);
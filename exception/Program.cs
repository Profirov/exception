﻿
try
{
    int num = int.Parse(Console.ReadLine());
    if (num < 0)
    {
        throw new ArgumentException();
    }

    double sqrt = Math.Sqrt(num);

    Console.WriteLine(sqrt);
}
catch(ArgumentException)
{
    Console.WriteLine("Invalid number.");
}
finally
{
    Console.WriteLine("Goodbye.");
}
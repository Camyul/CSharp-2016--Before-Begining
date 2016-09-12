using System;

class Program
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F2} {1:0.00}", (2 * radius) * (Math.PI), (Math.PI) * (Math.Pow(radius, 2)));
    }
}
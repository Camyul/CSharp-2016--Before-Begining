using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        double realm = (n * s) / 500d;
        Console.WriteLine("{0:F2}", realm * p);
    }
}
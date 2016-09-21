using System;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        if (b < a)
        {
            double c = b;
            b = a;
            a = c;
        }
        Console.WriteLine("{0} {1}", a, b);
    }
}
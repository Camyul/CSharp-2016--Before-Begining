using System;

class Program
{
    static void Main()
    {
        double weight = Convert.ToDouble(Console.ReadLine());
        double moonWeight = 0.17 * weight;
        Console.WriteLine("{0:N3}", moonWeight);
    }
}

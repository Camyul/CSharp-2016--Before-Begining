using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        short n = Convert.ToInt16(Console.ReadLine());
        List<double> numbers = new List<double>();
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            numbers.Add(double.Parse(Console.ReadLine()));
            
        }
        foreach (var number in numbers)
        {
            sum += number;
        }
        Console.WriteLine("min={0:F2}", numbers.Min());
        Console.WriteLine("max={0:F2}", numbers.Max());
        Console.WriteLine("sum={0:F2}", sum);
        Console.WriteLine("avg={0:F2}", sum/n);
    }
} 
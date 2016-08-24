using System;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        bool isEqual = false;
        if ((Math.Abs(a - b)) < 0.000001)
        {
            isEqual = true;
        }
        Console.WriteLine(isEqual);
    }
}

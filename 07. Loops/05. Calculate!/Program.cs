using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double sum = 1;
        long factorial = 1;
        double powX = 1; 
        for (int i = 1; i <= n; i++)
        {
            factorial =factorial * i;
            powX = powX * x;
            sum += (factorial / powX);
        }
        Console.WriteLine("{0:F5}", sum);
    }
}
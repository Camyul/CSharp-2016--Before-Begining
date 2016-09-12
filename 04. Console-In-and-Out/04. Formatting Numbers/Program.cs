using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.Write("{0,-10:X}|{1}|", a, Convert.ToString(a, 2).PadLeft(10, '0'));
        Console.WriteLine("{0,-10:F2}|{1,-10:F3}|", b, c);
    }
}
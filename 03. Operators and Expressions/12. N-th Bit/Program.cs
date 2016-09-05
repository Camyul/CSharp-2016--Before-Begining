using System;

class Program
{
    static void Main()
    {
        int p = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        int mask = 1 << n;
        int pAndMask = p & mask;
        Console.WriteLine(Convert.ToString(p, 2).PadLeft(24, '0'));
        Console.WriteLine(pAndMask >> n);
    }
}
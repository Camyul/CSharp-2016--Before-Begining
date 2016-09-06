using System;
class Program
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());
        if (v == 0)
        {
            int mask = ~(1 << p);
            n = n & (uint)mask;
        }
        else
        {
            int mask = 1 << p;
            n = n | (uint)mask;
        }
        Console.WriteLine(n);
    }
}
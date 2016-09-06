using System;

class Program
{
    static void Main()
    {
        uint n = Convert.ToUInt32(Console.ReadLine());
        uint[] p = new uint[6];
        int mask = new int();
        for (int i = 0; i <= 2; i++)
        {
            mask = 1 << (i + 3);
            p[i] = (n & (uint)mask) >> (i + 3);
        }
        for (int i = 3; i <= 5; i++)
        {
            mask = 1 << (i + 21);
            p[i] = (n & (uint)mask) >> (i + 21);
        }
        for (int i = 0; i <= 2; i++)
        {
            if (p[i] == 0)
            {
                mask = ~(1 << (i + 24));
                n = n & (uint)mask;
            }
            else
            {
                mask = 1 << (i + 24);
                n = n | (uint)mask;
            }
        }
        for (int i = 3; i <= 5; i++)
        {
            if (p[i] == 0)
            {
                mask = ~(1 << i);
                n = n & (uint)mask;
            }
            else
            {
                mask = 1 << i;
                n = n | (uint)mask;
            }
        }
        Console.WriteLine(n);
    }
}
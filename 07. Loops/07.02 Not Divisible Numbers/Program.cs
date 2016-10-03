using System;

class Program
{
    static void Main()
    {
        uint n = Convert.ToUInt32(Console.ReadLine());
        for (int i= 1; i <= n; i++)
        {
            if ((i % 3 == 0) || (i % 7 == 0))
            {
                continue;
            }
            Console.Write("{0} ", i);
        }
    }
}
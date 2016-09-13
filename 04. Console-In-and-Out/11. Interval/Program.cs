using System;


class Program
{
    static void Main()
    {
        short n = short.Parse(Console.ReadLine());
        short m = short.Parse(Console.ReadLine());
        byte count = 0;
        for (int i = n; i < m; i++)
        {
            if (((i % 5) == 0) && (i != n) && (i != m))
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}
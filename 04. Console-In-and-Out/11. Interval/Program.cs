using System;


class Program
{
    static void Main()
    {
        short n = short.Parse(Console.ReadLine());
        short m = short.Parse(Console.ReadLine());
        byte count = 0;
        for (int i = (n + 1); i < m; i++)
        {
            if ((i % 5) == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}
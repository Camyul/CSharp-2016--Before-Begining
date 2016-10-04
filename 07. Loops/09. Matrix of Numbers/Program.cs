using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int j = 1;
        while (j <= n)
        {
            Console.Write("{0} ", j);
            for (int i = j + 1; i < (n + j) ; i++)
            {
                Console.Write("{0} ", i);
            }
            j++;
            Console.WriteLine();
        }
    }
}
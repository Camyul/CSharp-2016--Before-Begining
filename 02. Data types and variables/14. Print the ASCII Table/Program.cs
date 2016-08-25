using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 256; i++)
        {
            if  ((i == 95) || (i == 190))
            {
                Console.WriteLine();
            }
            Console.Write((char)i);
        }
    }
}

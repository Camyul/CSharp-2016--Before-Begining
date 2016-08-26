using System;

class Program
{
    static void Main()
    {
        sbyte number = Convert.ToSByte(Console.ReadLine());
        sbyte rest = (sbyte)(number % 2);
        if (rest == 0)
        {
            Console.WriteLine("even {0}", number);
        }
        else
        {
            Console.WriteLine("odd {0}", number);
        }
    }
}

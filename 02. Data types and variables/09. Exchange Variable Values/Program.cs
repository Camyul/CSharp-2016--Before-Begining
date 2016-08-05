using System;


    class Program
    {
        static void Main()
        {
        int a = 5;
        int b = 10;
        Console.WriteLine("a = {0}",a);
        Console.WriteLine("b = {0}",b);
        b = a + b;
        a = b - a;
        b = b - a;
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
    }
    }

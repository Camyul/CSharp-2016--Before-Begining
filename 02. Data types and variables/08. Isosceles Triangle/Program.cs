using System;

    class Program
    {
        static void Main()
        {
        char symbolAt = '\x0040';
        char symbolSpace = '\u0020';
        Console.WriteLine("{0}{1}{2}{3}",symbolSpace, symbolSpace, symbolSpace, symbolAt);
        Console.WriteLine("{0}{1}{2}{3}{4}",symbolSpace, symbolSpace, symbolAt, symbolSpace, symbolAt);
        Console.WriteLine("{0}{1}{2}{3}{4}{5}", symbolSpace, symbolAt, symbolSpace, symbolSpace, symbolSpace, symbolAt);
        Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", symbolAt, symbolSpace, symbolAt, symbolSpace, symbolAt, symbolSpace, symbolAt);
        }
    }

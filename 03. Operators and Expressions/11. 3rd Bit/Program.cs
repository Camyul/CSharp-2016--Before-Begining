using System;

class Program
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        int position = 3;
        int mask = (1 << position);
        uint numberAndMask = number & (uint)mask;
        Console.WriteLine(numberAndMask >> position);
    }
}
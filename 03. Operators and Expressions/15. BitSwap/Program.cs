using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        //Stopwatch stopWatch = Stopwatch.StartNew();
        uint n = Convert.ToUInt32(Console.ReadLine());
        int p = Convert.ToInt32(Console.ReadLine());
        int q = Convert.ToInt32(Console.ReadLine());
        uint k = Convert.ToUInt32(Console.ReadLine());
        int mask = new int();
        uint[] bitOfP = new uint[k];
        uint[] bitOfQ = new uint[k];
        //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        for (int i = 0; i < k; i++)
        {
            mask = 1 << (p + i);
            bitOfP[i] = (n & (uint)mask) >> (p + i);
            mask = 1 << (q + i);
            bitOfQ[i] = (n & (uint)mask) >> (q + i); // Четем стойностите на битовете
        }
        for (int i = 0; i < k; i++)
        {
            if (bitOfQ[i] == 0)
            {
                mask = ~(1 << (p + i));
                n = n & (uint)mask; //Заместваме стойностите които са "0"
            }
            else
            {
                mask = 1 << (p + i);
                n = n | (uint)mask; //Заместваме стойностите, които са "1"
            }
            if (bitOfP[i] == 0)
            {
                mask = ~(1 << (q + i));
                n = n & (uint)mask; //Заместваме стойностите които са "0"
            }
            else
            {
                mask = 1 << (q + i);
                n = n | (uint)mask; //Заместваме стойностите, които са "1"
            }
        }
        Console.WriteLine(n);
        //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        //stopWatch.Stop();
        //Console.WriteLine(stopWatch.Elapsed);
    }
}
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        int sum = 0;
        int count = 0;
        int[] sums = new int(16);
        string numberToString = "";
        while (number > 9 && count <10)
        {
            number /= 10;
            numberToString = Convert.ToString(number);
            for (int i = 0; i < numberToString.Length; i+=2)
            {
                sum += Convert.ToInt32(numberToString.Substring(i, 1));
            }
            count++;
            if (count > 9)
            {
                break;
            }
        }
        Console.WriteLine(sum);
        Console.WriteLine(count);
    }
}
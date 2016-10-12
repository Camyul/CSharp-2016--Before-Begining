using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        int count = 0;
        
        int[] sums = new int[16];
        string numberToString = "";
        while (count < 10 && number >9)
        {
            int j = 0;
            Array.Clear(sums, 0, sums.Length);
            do
            {
                number /= 10;
                numberToString = Convert.ToString(number);
                for (int i = 0; i < numberToString.Length; i += 2)
                {
                    sums[j] += Convert.ToInt32(numberToString.Substring(i, 1));
                }
                j++;
                
            } while (number > 9);

            long product = 1;
            for (int i = 0; i < j; i++)
            {
                product *= sums[i];
            }
            number = product;
            count++;
            if (count > 9)
            {
                break;
            }
        }
        if (number > 9)
        {
            Console.WriteLine(number);
        }
        else
        {
            Console.WriteLine(count);
            Console.WriteLine(number);
        }
    }
}
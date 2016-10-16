using System;
class Students_to_Students_and_Bits_to_Bits
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string sequence = "";
        int ones = 0;
        int zeros = 0;

        for (int i = 0; i < n; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            sequence += Convert.ToString(num, 2).PadLeft(30, '0');
        }
        int count = 0;
        bool isZero = false;
        for (int i = 0; i < sequence.Length; i++)
        {
            string simbol= sequence.Substring(i, 1);
            int simbolToInt = int.Parse(simbol);
            
            if (simbolToInt == 1 && isZero == false)
            {
                count++;
                if (ones <= count)
                {
                    ones = count;
                }
            }
            else if (simbolToInt == 0 && isZero == false)
            {
                count = 1;
                isZero = true;
            }
            else if (simbolToInt == 1 && isZero == true)
            {
                count = 1;
                isZero = false;
            }
            else if (simbolToInt == 0 && isZero == true)
            {
                count++;
                if (zeros <= count)
                {
                    zeros = count;
                }
            }
        }
        Console.WriteLine(zeros);
        Console.WriteLine(ones);
    }
}
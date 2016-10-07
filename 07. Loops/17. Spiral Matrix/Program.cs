using System;


class Program
{
    static void PrintOnPosition(int x, int y, int symbol)
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(symbol);
    }
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int matrixLength = n * n;
        int[] matrixN = new int[matrixLength];
        for (int i = 0, j = 1; i < matrixLength; i++, j++)
        {
            matrixN[i] = j;
        }
        int count = 0;
        while (count < matrixLength)
        {
            int x = 0;
            int y = 0;
            while (count < n)
            {
                PrintOnPosition(x, y, matrixN[count]);
                x++;
                count++;
            }
        }
        //PrintOnPosition(10, 12, 33);
    }
}
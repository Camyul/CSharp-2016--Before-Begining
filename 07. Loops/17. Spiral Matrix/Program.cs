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
        Console.Clear();
        int matrixLength = n * n;
        int[] matrixN = new int[matrixLength];

        for (int i = 0, j = 1; i < matrixLength; i++, j++)
        {
            matrixN[i] = j;
        }
        int count = 0;
        int x = -1;
        int y = 0;
        int direction = 0;
        int clear = 0;
        while (count < matrixLength)
        {
            direction++;
            do
            {
                if (count == n * n)
                {
                    break;
                }
                x++;
                PrintOnPosition(x, y, matrixN[count]);
                count++;

            }
            while (x < (n - 1 - clear));
            clear++;
            do
            {
                if (count == n * n)
                {
                    break;
                }
                y++;
                PrintOnPosition(x, y, matrixN[count]);
                count++;

            }
            while (y < (n - clear));
            do
            {
                if (count == n * n)
                {
                    break;
                }
                x--;
                PrintOnPosition(x, y, matrixN[count]);
                count++;

            }
            while (x >= (0 + clear));
            do
            {
                if (count == n * n)
                {
                    break;
                }
                y--;
                PrintOnPosition(x, y, matrixN[count]);
                count++;

            }
            while (y > (0 + clear));
        }
        Console.WriteLine();
    }
}
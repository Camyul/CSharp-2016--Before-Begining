using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.Clear();
        int fieldSize = (2 *n) - 1;
        int mid = n - 1;
        char empty = ' ';
        char top = '/';
        char side = 'X';
        char edge = ':';
        for (int row = 0; row < fieldSize; row++)
        {
            for (int col = 0; col < fieldSize; col++)
            {
                if (col==0 && row >= mid ||
                    col == mid && row >=mid ||
                    col == fieldSize-1 && row <=mid ||
                    col >= mid && row ==0 ||
                    col <= mid && row == mid ||
                    col <=mid && row == fieldSize - 1 ||
                    row + col == mid ||
                    row + col == fieldSize - 1 + mid ||
                    row + col == fieldSize - 1 && row <= mid)
                {
                    //Vertical lines
                    Console.Write(edge);
                }
                else if (col > mid &&
                    row + col < fieldSize - 1 + mid &&
                    row + col > fieldSize - 1)
                {
                    Console.Write(side);
                }
                else if (row + col > mid && 
                    row + col < fieldSize - 1 + mid &&
                    row < mid)
                {
                    Console.Write(top);
                }
                else
                {
                    Console.Write(empty);
                }
            }
            Console.WriteLine();
        }
    }
}
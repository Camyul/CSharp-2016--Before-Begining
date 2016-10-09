using System;


class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        int[,] matrixN = new int[n,n];
        int col = 0;
        int row = 0;
        string direction = "right";
        for (int i = 1; i <= (n*n); i++)
        {
            if ((direction == "right") && ((col >= n) || (matrixN[row,col] != 0)))
            {
                direction = "down";
                col--;
                row++;
            }
            if ((direction == "down") && ((row >= n) || (matrixN[row, col] != 0)))
            {
                direction = "left";
                row--;
                col--;
            }
            if ((direction == "left") && ((col < 0) || (matrixN[row, col] != 0)))
            {
                direction = "up";
                col++;
                row--;
            }
            if ((direction == "up") && ((row <= 0) || (matrixN[row, col] != 0)))
            {
                direction = "right";
                row++;
                col++;
            }

            matrixN[row, col] = i;

            if (direction == "right")
            {
                col++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
        }
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,4}",matrixN[i,j]);
            }
            Console.WriteLine();
        }
    }
}
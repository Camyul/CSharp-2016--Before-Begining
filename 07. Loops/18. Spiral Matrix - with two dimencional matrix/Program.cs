using System;


class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        int matrixLength = n * n;
        int[,] matrixN = new int[n,n];
        int count = 1;
        int col = 0;
        int row = 0;
        string direction = "right";
        for (int i = 1; i <= matrixLength; i++)
        {
            if ((direction == "right") && (col > n))
            {
                direction = "down";
                col--;
            }
            matrixN[row, col] = i;
            if (direction == "right")
            {
                col++;
            }
        }
        
  
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrixN[i,j]);
            }
        }
    }
}
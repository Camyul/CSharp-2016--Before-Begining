using System;
class Cube_2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.Clear();
        int row = n-2;
        char space = ' ';
        char colon = ':';
        char slash = '/';
        char letter = 'X';
        char print = space;
        for (int i = 0; i < n -1; i++)
        {
            Console.Write(print);
            if ((i == n - 2) && (print == space))
            {
                i = 0;
                print = colon;
                Console.Write(print);
            }
        }
        Console.WriteLine(colon);
        for (int i = 0; i < n-2; i++)
        {
            for (int j = 0; j < row -i; j++)
            {
                Console.Write(space);
            }
            Console.Write(colon);
            for (int j = 0; j < n-2; j++)
            {
                Console.Write(slash);
            }
            Console.Write(colon);
            for (int j = row -i; j < n-2; j++)
            {
                Console.Write(letter);
            }
            Console.WriteLine(colon);
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(print);
            if ((i == n-1) && (print == colon))
            {
                i = 2;
                print = letter;
                Console.Write(print);
            }
        }
        Console.WriteLine(colon);

        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(colon);
            for (int j = 1; j < n - 1; j++)
            {
                Console.Write(space);
            }
            Console.Write(colon);

            for (int j = 1; j < row - i; j++)
            {
                Console.Write(letter);
            }
            Console.WriteLine(colon);
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(colon);
        }
    }
}
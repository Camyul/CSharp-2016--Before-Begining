using System;
using System.Threading;

class Program
{
    struct Rock
    {
        public int x;
        public int y;
        public string str;
        public ConsoleColor color;
    }
    static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.WriteLine(str);
    }
    static void Main()
    {
        Rock userPad = new Rock();
        userPad.x = 30;
        userPad.y = Console.WindowHeight - 1;
        userPad.str = "(0)";
        userPad.color = ConsoleColor.White;
        Console.BufferWidth = Console.WindowWidth = 60;
        Console.BufferHeight = Console.WindowHeight = 30;
        while (true)
        {
            //Move our object
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (userPad.x > 0)
                    {
                        userPad.x--;
                    }
                }
            }
            //Move rocks
            //Check if rocks hitting us
            //Clear the console
            Console.Clear();
            //Redraw rocks
            PrintStringOnPosition(userPad.x, userPad.y, userPad.str, userPad.color);
            //Draw info
            //Slow down program
            Thread.Sleep(200);
        }
    }
}

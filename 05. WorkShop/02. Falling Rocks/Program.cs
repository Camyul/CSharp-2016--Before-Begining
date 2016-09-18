using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    struct Rock
    {
        public int x;
        public int y;
        public string str;
        public int length;
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
        int livescount = 5;
        int playerfield = 60;
        int maxSizeRock = 5;
        Console.BufferWidth = Console.WindowWidth = 80;
        Console.BufferHeight = Console.WindowHeight = 30;
        Rock userPad = new Rock();
        userPad.x = playerfield / 2;
        userPad.y = Console.WindowHeight - 1;
        userPad.str = "(0)";
        userPad.color = ConsoleColor.White;
        Random randomGenerator = new Random();
        List<Rock> fallingRocks = new List<Rock>();
        while (true)
        {
            bool hitted = false;
            String[] symbolRock = { "^", "@", "*", "&", "+", "%", "$", "#", "!", ".", ";" };
            int numberSymbolRock = randomGenerator.Next(0, symbolRock.Length);
            int currentSizeRock = randomGenerator.Next(0, maxSizeRock);
            Rock newRock = new Rock();
            newRock.x = randomGenerator.Next(0, (playerfield - currentSizeRock + 1));
            newRock.y = 1;
            for (int i = 0; i < currentSizeRock; i++)
            {
                newRock.str += symbolRock[numberSymbolRock];
            }
            newRock.length = currentSizeRock;
            newRock.color = (ConsoleColor)randomGenerator.Next(0,16);
            fallingRocks.Add(newRock);
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
                if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (userPad.x < (playerfield - 3))
                    {
                        userPad.x++;
                    }

                }
            }
            //Move rocks
            List <Rock> tempRock = new List<Rock>();
            for (int i = 0; i < fallingRocks.Count; i++)
            {
                Rock oldRock = fallingRocks[i];
                Rock moveRock = new Rock();
                moveRock.x = oldRock.x;
                moveRock.y = oldRock.y + 1;
                moveRock.str = oldRock.str;
                moveRock.length = oldRock.length;
                moveRock.color = oldRock.color;
                for (int j = 0; j < moveRock.length; j++)
                {
                    if (((userPad.x == (moveRock.x + j)) || (userPad.x + 1 == (moveRock.x + j)) || (userPad.x + 2 == (moveRock.x + j))) && (userPad.y == moveRock.y))
                    {
                        if (livescount >= 0)
                        {
                            livescount--;
                            hitted = true;
                            break;
                        }
                    }
                }
                if (moveRock.y < Console.WindowHeight)
                {
                    tempRock.Add(moveRock);
                }
            }
            fallingRocks = tempRock;
            //Check if rocks hitting us
            //Clear the console
            Console.Clear();
            //Redraw playerfield
            foreach (Rock Rok in fallingRocks)
            {
                PrintStringOnPosition(Rok.x, Rok.y, Rok.str, Rok.color);
            }
            if (hitted == true)
            {
                PrintStringOnPosition(userPad.x, userPad.y, "XXX", ConsoleColor.Red);
                fallingRocks.Clear();
            }
            else
            {
                PrintStringOnPosition(userPad.x, userPad.y, userPad.str, userPad.color);
            }
            if (livescount < 0)
            {
                PrintStringOnPosition(20, 12, "GAME OVER", ConsoleColor.Red);
                PrintStringOnPosition(20, 13, "Press [Enter] to Continue...", ConsoleColor.Red);
                Console.ReadLine();
                Environment.Exit(0);
            }
            //Draw info
            PrintStringOnPosition(62, 5, "Lives: "+ livescount, ConsoleColor.White);
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                PrintStringOnPosition(playerfield, i, "|", ConsoleColor.White);
            }
            //Slow down program
            Thread.Sleep(150);
        }
    }
}

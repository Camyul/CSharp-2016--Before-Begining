﻿using System;
using System.Collections.Generic;
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
        
        Console.BufferWidth = Console.WindowWidth = 60;
        Console.BufferHeight = Console.WindowHeight = 30;
        Rock userPad = new Rock();
        userPad.x = 30;
        userPad.y = Console.WindowHeight - 1;
        userPad.str = "(0)";
        userPad.color = ConsoleColor.White;
        Random randomGenerator = new Random();
        List<Rock> fallingRocks = new List<Rock>();
        while (true)
        {
            
            Rock newRock = new Rock();
            newRock.x = randomGenerator.Next(0, Console.WindowWidth);
            newRock.y = 1;
            newRock.str = "%";
            newRock.color = ConsoleColor.Red;
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
                    if (userPad.x < (Console.BufferWidth - 4))
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
                moveRock.color = oldRock.color;
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
            PrintStringOnPosition(userPad.x, userPad.y, userPad.str, userPad.color);
            //Draw info
            //Slow down program
            Thread.Sleep(200);
        }
    }
}

﻿using System;

    class Program
    {
        static void Main()
        {
        int sign = 1;
        for (int i = 2; i < 12; i++)
        {
            Console.WriteLine(i * sign);
            sign = sign * (-1);
        }
        }
    }

﻿using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.WriteLine("enter an integer number");
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}


﻿using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("enter number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(number % 35 == 0);
    }
}


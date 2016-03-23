using System;
using System.Numerics;

class BitwiseExtractBitNumber3
{
    static void Main()
    {
        Console.WriteLine("enter number");
        int number = int.Parse(Console.ReadLine());
        int theThirdBit = (number >> 3) & 1;
        Console.WriteLine(theThirdBit);
    }
}


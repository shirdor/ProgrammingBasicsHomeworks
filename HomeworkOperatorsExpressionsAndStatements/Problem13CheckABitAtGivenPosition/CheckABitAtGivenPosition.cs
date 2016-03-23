using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
    Console.WriteLine("enter number");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine("enter position");
    int p = int.Parse(Console.ReadLine());
    int theBitAtPositionP = (number >> p) & 1;
    Console.WriteLine(theBitAtPositionP == 1 ? true : false);
    }
}


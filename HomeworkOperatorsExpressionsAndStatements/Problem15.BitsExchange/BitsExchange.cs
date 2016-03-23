using System;
using System.Numerics;

class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("enter number");
        uint number = uint.Parse(Console.ReadLine());
        uint firstBits = number >> 3;
        firstBits = firstBits << 29;
        firstBits = firstBits >> 26;
        uint secondBits = number << 5;
        secondBits = secondBits >> 29;
        secondBits = secondBits << 24;
        uint mask = firstBits ^ secondBits;
        uint result = number ^ mask;
        firstBits = firstBits << 21;
        result = result ^ firstBits;
        secondBits = secondBits >> 21;
        result = result ^ secondBits;
        Console.WriteLine(result);
    }
}


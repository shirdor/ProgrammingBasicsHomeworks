using System;
using System.Numerics;

class TrailingZeroesInN
{
    static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        BigInteger trailingZeroes = 0;
        BigInteger newNumber = number;
        while (newNumber > 0)
        {
            newNumber = newNumber / 5;
            trailingZeroes += newNumber;
        }
        Console.WriteLine(trailingZeroes);
    }
}


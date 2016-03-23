using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("enter number");
        int number = int.Parse(Console.ReadLine());
        BigInteger catalannumber = 1;
        BigInteger secondcatalannumber = 1;
        BigInteger thirdcatalannumber = 1;
        for (int i = 1; i <= 2*number; i++)
        {
            catalannumber *= i;
        }
        for (int i = 1; i <= number; i++)
        {
            secondcatalannumber *= i;
        }
        for (int i = 1; i <= number + 1; i++)
        {
            thirdcatalannumber *= i;
        }
        BigInteger result = catalannumber / (secondcatalannumber * thirdcatalannumber);
        Console.WriteLine(result);
    }
}


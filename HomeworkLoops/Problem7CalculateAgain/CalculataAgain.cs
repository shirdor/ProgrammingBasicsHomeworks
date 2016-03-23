using System;
using System.Numerics;

class CalculataAgain
{
    static void Main()
    {
        Console.WriteLine("enter n");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("enter k");
        int k = int.Parse(Console.ReadLine());
        BigInteger factorialOfN = 1;
        BigInteger factorialOfK = 1;
        BigInteger factorialOfNMinusK = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialOfN *= i;
            if (i <= k)
            {
                factorialOfK *= i;
            }
            else
            {
                continue;
            }
        }
        for (int i = 1; i <= (n - k); i++)
        {
            factorialOfNMinusK *= i;
        }
        BigInteger sum = factorialOfN / (factorialOfK * factorialOfNMinusK);
        Console.WriteLine("N! / (K!*(N - K)! = {0}", sum);
    }
}


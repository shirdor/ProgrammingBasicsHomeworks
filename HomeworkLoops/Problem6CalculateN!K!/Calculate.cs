using System;

class Calculate
{
    static void Main()
    {
        Console.WriteLine("enter n");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("enter k");
        int k = int.Parse(Console.ReadLine());
        int factorialOfN = 1;
        int factorialOfK = 1;
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
        int sum = factorialOfN / factorialOfK;
        Console.WriteLine("n!/k! = {0}", sum);
    }
}


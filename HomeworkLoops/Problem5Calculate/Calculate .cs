using System;

class Calculate
{
    static void Main()
    {
        Console.WriteLine("enter n");
        double n = double.Parse(Console.ReadLine());
        Console.WriteLine("enter k ");
        double k = double.Parse(Console.ReadLine());
        double theFactorial = 1;
        double sum = 1;
        for (int i = 1; i <= n ; i++)
        {
            theFactorial = theFactorial * i;
            sum += theFactorial / Math.Pow(k, i);
        }
        Console.WriteLine("{0:F5}", sum);
    }
}


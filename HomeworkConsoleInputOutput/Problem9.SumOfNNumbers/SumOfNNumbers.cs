using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        double sum = 0;
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            int chislo = int.Parse(Console.ReadLine());
            sum = sum + chislo;
           
        }
        Console.WriteLine("sum = " + sum);
    }
}   



using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("How much numbers you will enter: ");
        int numbers = int.Parse(Console.ReadLine());
        int firstNumber = int.Parse(Console.ReadLine());
        int sum = firstNumber;
        int maxValue = firstNumber;
        int minValue = firstNumber;
        for (int i = 1; i < numbers; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number > maxValue)
            {
                maxValue = number;
            }
            else if (number < minValue)
            {
                minValue = number;
            }
            sum += number;        
        }
        Console.WriteLine("min = {0}", minValue);
        Console.WriteLine("max = {0}", maxValue);     
        Console.WriteLine("sum = {0}", sum);
        double avarage = (double)sum / numbers;
        Console.WriteLine("avg = {0:0.00}",avarage);
    }
}


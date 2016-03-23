using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers with a space between them");
        string input = Console.ReadLine();
        string[] values = input.Split(' ');
        double firstNumber = double.Parse(values[0]);
        double secondNumber = double.Parse(values[1]);
        double thirdNumber = double.Parse(values[2]);
        double forthNumber = double.Parse(values[3]);
        double fifthNumber = double.Parse(values[4]);
        double sum = firstNumber + secondNumber + thirdNumber + forthNumber + fifthNumber;
        Console.WriteLine("sum= " + sum);
    }
}

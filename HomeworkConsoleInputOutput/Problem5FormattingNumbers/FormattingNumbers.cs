using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Enter a:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c:");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("|{0,-10:X}|{1, 2}|{2,10}|{3,-10:0.000}|",
            a, Convert.ToString(a, 2).PadLeft(10,'0'), b, c);
    }
}

using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("enter x");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("enter y");
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Pow(x,2)+Math.Pow(y,2)<=4);
    }
}


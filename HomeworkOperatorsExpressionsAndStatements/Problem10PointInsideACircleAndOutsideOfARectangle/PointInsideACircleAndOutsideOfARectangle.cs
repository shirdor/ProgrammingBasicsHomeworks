using System;

class PointInsideACircleAndOutsideOfARectangle
{
    static void Main()
    {
        Console.WriteLine("enter x");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("enter y");
        double y = double.Parse(Console.ReadLine());
        double xy = (Math.Pow(x, 2) + Math.Pow(y, 2));
        xy = Math.Pow(xy, 1/2);
        Console.WriteLine(x > -0.5 && x < 2.5 && y > 1 && y <= 2.5 && xy <= 2.25);
    }
}

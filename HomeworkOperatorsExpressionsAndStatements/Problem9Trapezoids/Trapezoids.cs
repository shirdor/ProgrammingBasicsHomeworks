using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("enter first basis");
        double sideA = double.Parse(Console.ReadLine());
        Console.WriteLine("enter second basis");
        double sideB = double.Parse(Console.ReadLine());
        Console.WriteLine("enter height");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("area = " +(sideA + sideB) * height / 2);
    }
}


using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("enter width");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("enter height");
        double height = double.Parse(Console.ReadLine());
        double perimeter = 2 * (width + height);
        double area = width * height;
        Console.WriteLine("perimeter = {0}", perimeter);
        Console.WriteLine("area = {0}", area);
    }
}


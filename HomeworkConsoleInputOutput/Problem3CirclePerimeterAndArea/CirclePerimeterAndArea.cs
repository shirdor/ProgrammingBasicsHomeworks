using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter radius: ");
        int radius = int.Parse(Console.ReadLine());
        double perimeter = 2 * radius * Math.PI;
        double area = radius * radius * Math.PI;
        Console.WriteLine( "perimeter = {0:0.00}", perimeter);
        Console.WriteLine("area = {0:0.00}", area);        
    }         
}

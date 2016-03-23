using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c:");
        double c = double.Parse(Console.ReadLine());
        double discriminant = Math.Pow(b, 2) - 4 * (a * c);
        double x1 = (-b + Math.Sqrt(discriminant)) / (2*a);
        double x2 = (-b - Math.Sqrt(discriminant)) / (2*a);
        if (discriminant > 0)
        {
            Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
        }
        else if (discriminant == 0)
        {
            Console.WriteLine("x1 = x2 = {0}",x1 );
        }
        else
        {
            Console.WriteLine("no roots");
        }
    }
}


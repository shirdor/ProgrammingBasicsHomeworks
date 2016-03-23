using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("enter weight");
        decimal weight = decimal.Parse(Console.ReadLine());
        Console.WriteLine("{0}",(17* weight)/100);
    }
}

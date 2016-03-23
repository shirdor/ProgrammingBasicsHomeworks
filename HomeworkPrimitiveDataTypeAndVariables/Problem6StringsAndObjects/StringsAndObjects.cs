using System;

class StringsAndObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object stringObject = hello + " " + world;
        string helloWorld = (string)stringObject;
        Console.WriteLine(helloWorld);
    }
}

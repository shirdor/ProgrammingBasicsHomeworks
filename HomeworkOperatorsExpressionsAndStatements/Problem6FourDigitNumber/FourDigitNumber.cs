using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("enter number");
        int number = int.Parse(Console.ReadLine());
        int firstDigit = number / 1000;
        int secondDigit = (number / 100) % 10;
        int thirdNummber = (number / 10) % 10;
        int forthNumber = number % 10;
        Console.WriteLine(firstDigit + secondDigit + thirdNummber + forthNumber);
        Console.WriteLine("{0}{1}{2}{3}",forthNumber, thirdNummber, secondDigit, firstDigit);
        Console.WriteLine("{3}{0}{1}{2}", firstDigit, secondDigit, thirdNummber, forthNumber);
        Console.WriteLine("{0}{1}{2}{3}", firstDigit, thirdNummber, secondDigit, forthNumber);
    }
}


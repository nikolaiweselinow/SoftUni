using System;
//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
class FourDigitNumber
{
    static void Main()
    {
        Console.Title = "Problem 6. Four-Digit Number";

        Console.Write("Enter four-digit number in format(e.g. 2011): ");
        int n = int.Parse(Console.ReadLine());

        int a = n % 10;             //last digit
        int b = (n / 10) % 10;
        int c = (n / 100) % 10;
        int d = (n / 1000) % 10;    //first digit

        int sumOfDigits = a + b + c + d;

        Console.WriteLine("Sum of digits is: {0}", sumOfDigits);
        Console.WriteLine("Reversed number is: {0}{1}{2}{3}", a, b, c, d);
        Console.WriteLine("Last digit in front: {0}{1}{2}{3}", a, d, c, b);
        Console.WriteLine("Second and third digits exchanged: {0}{1}{2}{3}", d, b, c, a);

    }
}
using System;
//Write an expression that checks for given integer if its third digit from right-to-left is 7.
class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.Title = "Problem 5. Third Digit is 7?";

        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());

        bool thirdDigit = (n / 100) % 10 == 7;

        Console.WriteLine("Is it third digit from right- to- left is 7? --->> {0}", thirdDigit);
    }
}
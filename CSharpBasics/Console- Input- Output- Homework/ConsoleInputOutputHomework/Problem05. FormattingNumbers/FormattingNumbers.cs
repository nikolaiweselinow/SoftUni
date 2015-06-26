using System;
using System.Globalization;
using System.Threading;
//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.
class FormattingNumbers
{
    static void Main()
    {
        Console.Title = ("Problem 5. Formatting Numbers");
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; //The user input 3.5 or 3,5 and don`t have exception
        Console.WriteLine("Input a three numbers.\na- integer between 0 and 500\nb and c - floating point number\n");
        Console.Write("a =  ");
        int a = int.Parse(Console.ReadLine());

        if (a < 0 || a > 500)
        {
            Console.WriteLine("Invalid input for \"a\"");
            return;
        }

        Console.Write("b = ");
        string secondNum = Console.ReadLine();
        secondNum = secondNum.Replace(",", ".");
        double b = double.Parse(secondNum);

        Console.Write("c = ");
        string thirdNum = Console.ReadLine();
        thirdNum = thirdNum.Replace(",", ".");
        double c = double.Parse(thirdNum);

        Console.Write("\n|{0}|", a.ToString("X").PadRight(10, ' '));
        Console.Write("{0}", Convert.ToString(a, 2).PadLeft(10, '0'));
        Console.Write("|{0,10:0.00}|", b);
        Console.WriteLine("{0,-10:0.000}|", c);

        
    }
}
using System;
using System.Globalization;
using System.Threading;
//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

class NumberComparer
{
    static void Main(string[] args)
    {
        Console.Title = "Problem 4. Number Comparer";
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; //The user input 3.5 or 3,5 and don`t have exception

        Console.Write("Enter a first number: ");
        string first = Console.ReadLine();
        first = first.Replace(",", ".");
        double firstNumber = double.Parse(first);

        Console.Write("Enter a second number: ");
        string second = Console.ReadLine();
        second = second.Replace(",", ".");
        double secondNumber = double.Parse(second);

        Console.WriteLine("The greater number of {0} and {1} is: {2}", firstNumber, secondNumber, Math.Max(firstNumber, secondNumber));
    }
}
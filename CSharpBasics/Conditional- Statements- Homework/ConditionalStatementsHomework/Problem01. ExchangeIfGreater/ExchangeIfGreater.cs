using System;
//Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space. 
class ExchangeIfGreater
{
    static void Main()
    {
        Console.Title = "Problem 1.	Exchange If Greater";

        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber) 
            Console.WriteLine("{0} {1}", secondNumber, firstNumber);
        else
            Console.WriteLine("{0} {1}",firstNumber, secondNumber);


        //another way without if- statements
        Console.WriteLine("{0} {1}", 
            Math.Min(firstNumber, secondNumber), 
            Math.Max(firstNumber, secondNumber)
            );
    }
}


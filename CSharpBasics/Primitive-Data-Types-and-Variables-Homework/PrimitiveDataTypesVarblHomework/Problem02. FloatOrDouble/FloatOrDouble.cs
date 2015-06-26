using System;
//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? Write a program to assign the numbers in variables and print them to ensure no precision is lost.

class FloatOrDouble
{
    static void Main()
    {
        double fisrtVariable = 34.567839023;
        float secondVariable = 12.345f;
        double thirdVariable = 8923.1234857;
        float fourthVariable = 3456.091f;

        Console.WriteLine("First number: {0}", fisrtVariable);
        Console.WriteLine("Second number: {0}", secondVariable);
        Console.WriteLine("Third number: {0}", thirdVariable);
        Console.WriteLine("Fourth number: {0}", fourthVariable);
    }
}


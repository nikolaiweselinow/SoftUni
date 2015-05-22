using System;
//Problem 6.	Print Numbers
//Write a program to print the numbers 1, 101 and 1001, each at a separate line. Name the program correctly. You should submit in your homework the Visual Studio project holding the source code of the PrintNumbers program.


class PrintNumbers
{
    static void Main()
    {
        //first way
        int number1 = 1;
        int number2 = 101;
        int number3 = 1001;

        Console.WriteLine(number1);
        Console.WriteLine(number2);
        Console.WriteLine(number3);

        Console.WriteLine(new string('=', 20));

        //second way
        Console.WriteLine("1\n101\n1001");

        Console.WriteLine(new string('=', 20));

        //third way
        Console.WriteLine("{0}\n{1}\n{2}", number1, number2, number3);
    }
}


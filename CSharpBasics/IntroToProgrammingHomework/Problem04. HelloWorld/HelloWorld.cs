using System;
//Problem 4.	Hello World
//Create, compile and run a “Hello C#” console application. Ensure you have named the application well (e.g. “”HelloCSharp”). You should submit the Visual Studio project holding the HelloCSharp class as part of your homework.

//Please active WordWrap and LineNumbers
//EDIT --> Advanced --> WordWrap
//TOOLS --> Options --> TextEditor --> AllLanguages --> General --> LineNumbers

class HelloWorld
{
    static void Main()
    {
        //first way
        string greatingMsg = "Hello World";
        Console.WriteLine(greatingMsg);

        Console.WriteLine(new string('=', 20));

        //or Console.WriteLine with placeholder
        Console.WriteLine("{0}", greatingMsg);

        Console.WriteLine(new string('=', 20));

        //second way
        Console.WriteLine("Hello World");
    }
}


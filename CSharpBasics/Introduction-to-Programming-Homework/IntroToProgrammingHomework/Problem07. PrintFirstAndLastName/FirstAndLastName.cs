using System;
//Problem 7.	Print First and Last Name
//Create console application that prints your first and last name, each at a separate line.

class FirstAndLastName
{
    static void Main()
    {
        string firstName = "Kamba";
        string lastName = "Kambov";
        //first way
        Console.WriteLine(firstName);
        Console.WriteLine(lastName);

        Console.WriteLine(new string('=', 20));

        //second way
        Console.WriteLine("{0}\n{1}", firstName, lastName);
        
    }
}


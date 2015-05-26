using System;
//Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console. Try to add some number or the null literal to these variables and print the result.

class NullValuesArithmetic
{
    static void Main()
    {
        //int myIntTest = null; //NON- NULLABLE Value Type
        //double myDoubleTest = null; //NON- NULLABLE Value Type

        int? myNullInt = null;
        double? myNullDouble = null;

        Console.WriteLine(myNullInt);
        Console.WriteLine(myNullDouble);

        Console.WriteLine(new string('-',10));

        myNullInt = 5;
        myNullDouble = 10.55;
        Console.WriteLine(myNullInt);
        Console.WriteLine(myNullDouble);
    }
}

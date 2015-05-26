using System;
//Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between). Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
class StringsAndObjects
{
    static void Main()
    {
        string firstStr = "Hello";
        string secondStr = "World";
        object concatStr = firstStr + " " + secondStr;

        Console.WriteLine("First string: {0}", firstStr);
        Console.WriteLine("Second string: {0}", secondStr);
        Console.WriteLine("Concatenation with object variable: {0}", concatStr);   

        Console.WriteLine();

        string thirdString = (string)concatStr;
        Console.WriteLine("Third string with casting object value : {0}", thirdString);               
    }
}


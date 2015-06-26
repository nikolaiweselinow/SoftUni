using System;

//Write a program that, depending on the user’s choice, inputs an int, double or string variable. If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement

class PlayWithIntDoubleAndString
{
    static void Main(string[] args)
    {
        Console.Title = "Problem 9.	Play with Int, Double and String";

        Console.WriteLine(@"Please choose a type:
1 --> int
2 --> double
3 --> string
");
        Console.Write("Your choice: ");

        int choice = int.Parse(Console.ReadLine());
        int myInt;
        double myDouble;
        string myString;
        switch (choice)
        {
            case 1:
                Console.Write("Please enter an int: ");
                myInt = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}", myInt + 1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                myDouble = double.Parse(Console.ReadLine());
                Console.WriteLine("{0}", myDouble + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                myString = (Console.ReadLine());
                Console.WriteLine("{0}*", myString);
                break;
            default:
                break;
        }
    }
}

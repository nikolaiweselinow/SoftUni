using System;

//Write an expression that checks if given integer is odd or even.
class OddOrEven
{
    static void Main()
    {

        Console.Title = "Problem 1.	Odd or Even Integers";

        int n = int.Parse(Console.ReadLine());
        bool isOdd = (n % 2 == 0) ? false : true;

        Console.WriteLine(isOdd);


        //another way
        //Comment selection (CTRL + K + C)
        //Uncomment selectino  (CTRL + K + U)

        //if (n % 2 == 0)
        //{
        //    isOdd = false;
        //}
        //else
        //{
        //    isOdd = true;
        //}
        //Console.WriteLine(isOdd);
    }
}


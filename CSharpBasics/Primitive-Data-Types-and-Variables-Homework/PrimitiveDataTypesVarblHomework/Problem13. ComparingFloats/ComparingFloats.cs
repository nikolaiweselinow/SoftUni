using System;
//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

class ComparingFloats
{
    static void Main()
    {
        Console.Write("Enter value of number A: ");
        double firstNum = double.Parse(Console.ReadLine());

        Console.Write("Enter value of number B: ");
        double secondNum = double.Parse(Console.ReadLine());

        double expression = Math.Abs(firstNum - secondNum);
        bool equal = expression < 0.000001;

        if (equal == true)
        {
            Console.WriteLine("The difference  {0} < 0.000001\nEqual: {1}", expression, equal);
        }
        else
        {
            Console.WriteLine("The difference {0} > 0.000001\nEqual: {1}", expression, equal);
        }    
    }
}


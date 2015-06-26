using System;
using System.Linq;


class SumOfFiveNum
{
    static void Main()
    {
        Console.Title = "Problem 7.	Sum of 5 Numbers";

        string input = Console.ReadLine();
        string[] inputAsString = input.Split(' ');
        decimal[] numbers = new decimal[inputAsString.Length]; //масив от тип decimal с цел да мога да използвам метода Sum() от библитеката System.Linq

        for (int i = 0; i < inputAsString.Length; i++)
        {
            numbers[i] = decimal.Parse(inputAsString[i]);
        }
        Console.WriteLine("Sum of: ");

        foreach (var item in numbers)
        {
            Console.Write(item + " + ");
        }
        Console.Write("\b\b ");  //изчиствам последния "+"
        Console.WriteLine("= {0}", numbers.Sum());
    }
}

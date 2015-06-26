using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OddEvenElements
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');
        var asIntegers = numbers.Select(s => int.Parse(s)).ToArray();
       

        int oddSum = 0;
        var oddMin = 0.00;
        var oddMax = 0.00;

        int evenSum = 0;
        var evenMin = 0.00;
        var evenMax = 0.00;


        for (int i = 0; i < asIntegers.Length; i++)
        {
            if (IsOdd(asIntegers[i]))
            {
                oddSum = oddSum + asIntegers[i];
                oddMin = asIntegers.Min();
                oddMax = asIntegers.Max();
            }
            else
            {
                evenSum = evenSum + asIntegers[i];
                evenMin = asIntegers.Min();
                evenMax = asIntegers.Max();
            }
            
        }
        Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={4}", oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
    }

    public static bool IsOdd(int value)
    {
        return value % 2 != 0;
    }
}


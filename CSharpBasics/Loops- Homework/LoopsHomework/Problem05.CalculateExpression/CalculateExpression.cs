using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CalculateExpression
{
    static void Main()
    {
        Console.Title = "Problem 5.	Calculate 1 + 1!/X + 2!/X2 + … + N!/XN";

        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        int nFactorial = 1;
        double result = 1;

        for (int i = 1; i <= n; i++)
        {
            nFactorial = nFactorial * i;
            result = result + nFactorial / Math.Pow(x, i);        
        }
        Console.WriteLine("{0:f5}",result);

    }
}


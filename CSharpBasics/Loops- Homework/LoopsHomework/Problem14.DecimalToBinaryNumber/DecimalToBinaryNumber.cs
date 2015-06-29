using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Title = "Problem 14.	Decimal to Binary Number";

        Console.Write("Number: ");
        long number = long.Parse(Console.ReadLine());

        long remainder;
        string result = string.Empty;
        while (number > 0)
        {
            remainder = number % 2;
            number = number / 2;
            result = remainder.ToString() + result;
        }
        Console.WriteLine("Binary: {0}", result);





        //another way
        //uncomment (CTRL + K + U)

        //Console.Write("Number: ");
        //long number = long.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString(number, 2));
    }
}


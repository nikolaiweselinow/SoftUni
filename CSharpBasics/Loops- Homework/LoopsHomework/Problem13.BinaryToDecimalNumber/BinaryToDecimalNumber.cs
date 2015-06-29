using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Title = "Problem 13.	Binary to Decimal Number";

        string binaryNum = Console.ReadLine();
        long decimalNum = 0;

        for (int i = 0, bit = binaryNum.Length - 1; i < binaryNum.Length; i++, bit--)
        {
            long curNum = long.Parse(binaryNum[bit].ToString());
            decimalNum += curNum * ((long)Math.Pow(2, i));            
        }

        Console.WriteLine(decimalNum);
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15.HexadecimalToDecimalNumber
{
    class HexadecimalToDecimalNumber
    {
        static void Main(string[] args)
        {
            Console.Title = "Problem 15.	Hexadecimal to Decimal Number";

            string hex = Console.ReadLine();
            long decNum = 0;

            for (int i = 0, bit = hex.Length - 1; i < hex.Length; i++, bit--)
            {
                long curNum;
                if ((hex[bit] - '7') >= 10)
                {
                    curNum = hex[bit] - '7';
                }
                else
                {
                    curNum = long.Parse(hex[bit].ToString());
                }

                decNum = decNum + curNum * ((long)Math.Pow(16, i));
            }
            Console.WriteLine(decNum);
        }
    }
}

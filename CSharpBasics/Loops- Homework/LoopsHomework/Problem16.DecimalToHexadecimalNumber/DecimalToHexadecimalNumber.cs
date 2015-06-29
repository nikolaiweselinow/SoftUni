using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem16.DecimalToHexadecimalNumber
{
    class DecimalToHexadecimalNumber
    {
        static void Main()
        {
            Console.Title = "Problem 16.	Decimal to Hexadecimal Number";

            
            long decNum = long.Parse(Console.ReadLine());
            StringBuilder hex = new StringBuilder();

            while (decNum > 0)
            {
                long curNum = decNum % 16;

                if (curNum >= 10)
                {
                    hex.Insert(0, (char)(curNum + '7'));
                }
                else
                {
                    hex.Insert(0, curNum);
                }

                decNum = decNum / 16;
            }

            Console.WriteLine(hex);
        }
    }
}

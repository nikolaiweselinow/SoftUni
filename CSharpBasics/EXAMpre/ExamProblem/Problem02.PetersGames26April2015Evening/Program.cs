using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02.PetersGames26April2015Evening
{
    class Program
    {
        static void Main(string[] args)
        {
            int startPos = int.Parse(Console.ReadLine());
            int endPos = int.Parse(Console.ReadLine());

            char myString = char.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = startPos; i < endPos; i++)
            {
                if (i % 5 == 0)
                {
                    sum = sum + i;    
                }
                else
                {
                    sum = sum + (i % 5);
                }                
            }

            string sumAsString = sum.ToString();
            if (sum % 2 == 0)
            {
                Console.WriteLine(sumAsString.Replace(sumAsString[0], myString));
            }        
        }
    }
}

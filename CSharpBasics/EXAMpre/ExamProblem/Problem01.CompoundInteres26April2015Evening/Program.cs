using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problem01.CompoundInteres26April2015Evening
{
    class Program
    {
        static void Main(string[] args)
        {
            double p = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double i = double.Parse(Console.ReadLine());
            double f = double.Parse(Console.ReadLine());


            double bankLoan = p * Math.Pow((1.0 + i), n);
            double friendLoan = p * (1 + f);

            if (bankLoan < friendLoan)
            {
                Console.WriteLine("{0:f2} Bank",bankLoan);
            }
            else
            {
                Console.WriteLine("{0:f2} Friend", friendLoan);
            }
        }
    }
}

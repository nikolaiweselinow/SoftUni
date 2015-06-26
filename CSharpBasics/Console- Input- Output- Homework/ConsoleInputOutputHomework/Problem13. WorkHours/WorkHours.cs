using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WorkHours
{
    static void Main()
    {
        double hours = double.Parse(Console.ReadLine());
        double days = double.Parse(Console.ReadLine());
        double percent = double.Parse(Console.ReadLine());

        double workdays = (days * 0.9) * 12.0 * (percent / 100.0);
        int result = (int)hours - (int)workdays;
        if (result > 0)
        {
            Console.WriteLine("No\n{0}", -result);
        }
        else
        {
            Console.WriteLine("Yes\n{0}", result);
        }
    }
}

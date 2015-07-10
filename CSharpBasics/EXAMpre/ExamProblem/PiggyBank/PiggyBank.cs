using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PiggyBank
{
    static void Main()
    {
        const int daysInMonths = 30;
        const int monthsInYear = 12;

        int price = int.Parse(Console.ReadLine());
        int partyDays = int.Parse(Console.ReadLine());

        if (partyDays == 30 || price <= 0)
        {
            Console.WriteLine("never");
        }      

        int normalDays = daysInMonths - partyDays;
        int saveMoneyInNormalDay = normalDays * 2;
        int spendsMoneyInParty = partyDays * 5;

       

        int saveMoneyPerMonth = saveMoneyInNormalDay - spendsMoneyInParty;

        int totalMoths = (int)Math.Ceiling(price / (double)saveMoneyPerMonth);

        int yearNeeded = totalMoths / monthsInYear;
        int monthsNeeded = (int)Math.Ceiling(totalMoths % (double)monthsInYear);
        if (yearNeeded < 0 && monthsNeeded < 0)
        {
           Console.WriteLine("never"); 
        }
        else
        {
            Console.WriteLine("{0} years, {1} months", yearNeeded, monthsNeeded);
        }        
    }
}

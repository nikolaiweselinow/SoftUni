using System;

class BookProblem
{
    static void Main()
    {
        const int daysInMonth = 30;
        const int monthsInYear = 12;

        int pagesOfBook = int.Parse(Console.ReadLine());
        int campingDays = int.Parse(Console.ReadLine());
        int pagesPerDay = int.Parse(Console.ReadLine());

        int normalDays = daysInMonth - campingDays;
        int normalRead = normalDays * pagesPerDay;

        if (normalDays <= 0 || pagesPerDay == 0)
        {
            Console.WriteLine("never");
            return;
        }

        int totalMonhts = (int)Math.Ceiling((double)pagesOfBook / normalRead);

        int years = totalMonhts / monthsInYear;
        int months = totalMonhts % monthsInYear;

        if (years < 0 && months < 0)
        {
            Console.WriteLine("never");
        }
        else
        {
            Console.WriteLine("{0} years {1} months", years, months);
        }
    }
}


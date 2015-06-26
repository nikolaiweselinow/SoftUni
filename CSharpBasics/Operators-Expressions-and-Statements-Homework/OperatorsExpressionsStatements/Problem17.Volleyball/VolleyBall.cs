using System;
//Може да се направят още проверки и да се реши по друг начин, но пък това решение носи 100 точки и го оставям така.
//Дано и на изпита да има такива лесни задачи.
class VolleyBall
{
    const int totalWeekendsInTheYear = 48;

    static void Main()
    {
       // Console.Title = "Problem 17. **– Volleyball(EXAM PROBLEMS)";

        string typeOfYear = Console.ReadLine(); //leap or normal
        int holidays = int.Parse(Console.ReadLine()); //number of holidays in the year (which are not Saturday or Sunday
        int homeTownWeekends = int.Parse(Console.ReadLine()); //number of weekends that Vladi spends in his hometown.

        int normalnWeekends = totalWeekendsInTheYear - homeTownWeekends;

        double normalWeekendPlays = normalnWeekends * (3 / 4.0);
        double holidayPlays = holidays * (2 / 3.0);

        double totalPlays = homeTownWeekends + normalWeekendPlays + holidayPlays;

        if (typeOfYear == "leap")
        {
            totalPlays = totalPlays * 1.15;             
        }

        Console.WriteLine((int)totalPlays);
    }
}

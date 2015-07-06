using System;

//Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them. 
class DifferenceBetweenDates
{
    static int daysDifference(DateTime startDate, DateTime endDate)
    {
        int days = (int)(endDate - startDate).TotalDays;
        return days;
    }

    static void Main()
    {
        Console.Title = "Problem 4.	Difference between Dates";

        Console.Write("Enter start date(dd.MM.yyyy): ");
        DateTime startDate;
        bool startDateParse = DateTime.TryParse(Console.ReadLine(), out startDate);

        Console.Write("Enter end date(dd.MM.yyyy): ");
        DateTime endDate;
        bool endDateParse = DateTime.TryParse(Console.ReadLine(), out endDate);

        if (startDateParse && endDateParse)
        {
            Console.WriteLine(daysDifference(startDate, endDate));
        }
        else
        {
            Console.WriteLine("invalid input");
        }
    }
}


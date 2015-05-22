using System;
//Problem 14.	* Current Date and Time
//Create a console application that prints the current date and time. Find in Internet how.

class CurentDateAndTime
{
    static void Main()
    {
        DateTime dateTimeNow = DateTime.Now;

        Console.WriteLine("Днес е:  {0}", dateTimeNow.ToString("dd.mm.yyyy"));
        Console.WriteLine("Ден: {0}", dateTimeNow.ToString("dddd"));
        Console.WriteLine("Месец: {0}", dateTimeNow.ToString("MMMM"));
        Console.WriteLine("Часът е: {0}", dateTimeNow.ToString("HH:MM"));

    }
}

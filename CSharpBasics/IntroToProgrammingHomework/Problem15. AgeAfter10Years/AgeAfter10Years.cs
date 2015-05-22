using System;
//Problem 15.	* Age after 10 Years
//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.


class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Please enter your birthday in format (dd.mm.yyyy) : ");

        DateTime birthDay;
        DateTime dateTimeNow = DateTime.Now;
        string stringDate = Console.ReadLine();
        int age;

        
        if (DateTime.TryParse(stringDate, out birthDay))
        {
            birthDay = DateTime.Parse(stringDate);
            age = dateTimeNow.Year - birthDay.Year;

            if (dateTimeNow.Month < birthDay.Month)
            {
                age--;
                Console.WriteLine("You are {0} years old\nAfter 10 years, you will be {1}", age, age + 10);
            }
            else if (dateTimeNow.Month == birthDay.Month && dateTimeNow.Day < birthDay.Day)
            {
                age--;
                Console.WriteLine("You are {0} years old\nAfter 10 years, you will be {1}", age, age + 10);
            }

            else if (dateTimeNow.Month == birthDay.Month && dateTimeNow.Day == birthDay.Day)
            {
                Console.WriteLine("Happy birthday. You are {0} years old\nAfter 10 years, you will be {1}", age, age + 10);
            }
            else
            {
                Console.WriteLine("You are {0} years old\nAfter 10 years, you will be {1}", age, age + 10);
            }
        }
        else
        {
            Console.WriteLine("Invalid Date Format");
        }        
    }
}



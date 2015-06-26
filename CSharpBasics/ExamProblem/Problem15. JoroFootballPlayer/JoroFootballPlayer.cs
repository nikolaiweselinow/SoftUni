using System;
class JoroFootballPlayer
{
    static void Main()
    {
        // Може да се реши по доста по- добър начин, но изпробвах решението и ми даде 100 точки в Judge
        // Според мен няма смисъл да се оптимизира, по- добре да има повече време за по- трудните задачи
        string year = Console.ReadLine();
        int numberOfHolidays = int.Parse(Console.ReadLine());
        int numberOfWeekends = int.Parse(Console.ReadLine());

        double result = numberOfWeekends + ((52 - numberOfWeekends) * (2 / 3.0)) + (numberOfHolidays * 0.5);
        if (year == "t")
        {
            result = result + 3;
        }
        Console.WriteLine((int)result);                
    }
}


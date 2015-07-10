using System;

class TravellerBob
{
    static void Main()
    {
        const int monthsInYear = 12;

        string typeOfYear = Console.ReadLine();
        int contractMonth = int.Parse(Console.ReadLine());
        int familyMonth = int.Parse(Console.ReadLine());

        int normalMonths = monthsInYear - contractMonth - familyMonth;
        double travelsInContract = (contractMonth * 4) * 3;
        double travelsInFamily = (familyMonth * 2) * 2;
        double travelsInNormal = (12 * normalMonths) * 3 / 5.0;

        double totalTravels = 0;
        if (typeOfYear == "leap")
        {
            totalTravels = (travelsInContract + travelsInFamily + travelsInNormal) * 1.05;
            Console.WriteLine("{0}", (int)totalTravels);
        }
        else
        {
            totalTravels = (travelsInContract + travelsInFamily + travelsInNormal);
            Console.WriteLine("{0}", (int)totalTravels);
        }
    }
}


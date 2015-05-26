using System;
//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//•	First name
//•	Last name
//•	Age (0...100)
//•	Gender (m or f)
//•	Personal ID number (e.g. 8306112507)
//•	Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

class EmployeeData
{
    static void Main()
    {
        string firstName = "Nikolay";
        string lastName = "Vasilev";
        byte age = 24;
        char gender = 'm';
        string personalID = "8306112507";
        string employeeNumber = "27569999";

        Console.WriteLine("First name: {0}\t\t | type: {1}", firstName, firstName.GetTypeCode());
        Console.WriteLine("Last name: {0}\t\t | type: {1}", lastName, lastName.GetTypeCode());
        Console.WriteLine("Age: {0}\t\t\t\t | type: {1}", age, age.GetTypeCode());
        Console.WriteLine("Gender: {0}\t\t\t | type: {1}", gender, gender.GetTypeCode());
        Console.WriteLine("Personal ID: {0}\t\t | type: {1}", personalID, personalID.GetTypeCode());
        Console.WriteLine("Unique Employee number: {0} | type: {1}", employeeNumber, employeeNumber.GetTypeCode());
    }
}


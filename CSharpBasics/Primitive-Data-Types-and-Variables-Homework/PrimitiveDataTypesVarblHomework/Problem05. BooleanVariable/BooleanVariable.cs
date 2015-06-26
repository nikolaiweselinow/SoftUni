using System;
//Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender. Print it on the console.	
class BooleanVariable
{
    static void Main()
    {
        Console.Write("Please enter your gender ( m or f) : ");
        char gender = char.Parse(Console.ReadLine());
        bool isFemale;
        if (gender == 'm')
        {
            isFemale = false;
            Console.WriteLine("Are you Female: {0}", isFemale);
        }
        else if (gender == 'f')
        {
            isFemale = true;
            Console.WriteLine("Are you Female: {0}", isFemale);
        }
        else
        {
            Console.WriteLine("Invalid gender");
        }        
    }
}

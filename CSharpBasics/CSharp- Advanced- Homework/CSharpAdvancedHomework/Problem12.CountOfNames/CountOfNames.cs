using System;
using System.Collections.Generic;
using System.Linq;


class CountOfNames
{
    static void Main()
    {
        Console.Title = "Problem 12.	Count of Names";

        Console.WriteLine("Enter list of names on a line, separated by a space:");
        List<string> input = new List<string>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        List<string> names = input.Distinct().OrderBy(c => c).ToList();

        foreach (string name in names)
        {
            Console.WriteLine("{0} -> {1}", name, input.Count(x => x == name));
        }
    }
}

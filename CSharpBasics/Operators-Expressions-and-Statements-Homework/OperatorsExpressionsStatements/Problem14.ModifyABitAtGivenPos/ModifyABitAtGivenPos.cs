using System;
//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
class ModifyABitAtGivenPos
{
    static void Main()
    {
        Console.Title = "Problem 14. Modify a Bit at Given Position";

        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter a position: ");
        int index = int.Parse(Console.ReadLine());

        Console.Write("Value of bit [0 or 1]: ");
        int bitValue = int.Parse(Console.ReadLine());

        Console.WriteLine("Binary representation of number {0} is : {1}", number, Convert.ToString(number, 2).PadLeft(16, '0'));
        Console.WriteLine("Before: {0}", number);

        if (bitValue == 0)
        {
            number = (number & ~(1 << index));
        }
        else
        {
            number = number | (1 << index);
        }
        Console.WriteLine("Binary representation of number {0} is : {1}", number, Convert.ToString(number, 2).PadLeft(16, '0'));
        Console.WriteLine("After: {0}", number);

    }
}
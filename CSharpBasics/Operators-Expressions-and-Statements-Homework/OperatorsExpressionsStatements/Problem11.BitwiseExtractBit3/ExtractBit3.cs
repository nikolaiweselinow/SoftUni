using System;

class ExtractBit3
{
    static void Main()
    {
        Console.Title = "Problem 11. Bitwise: Extract Bit #3";
       
        Console.Write("Input positive number : ");
        uint n = uint.Parse(Console.ReadLine());

        if (n >= 0)
        {
            uint bit = (n >> 3) & 1;
            Console.WriteLine("Binary representation: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine("Bit #3 is: {0}", bit);
        }
        else
        {
            Console.WriteLine("Invalid value!");
        }
    }
}
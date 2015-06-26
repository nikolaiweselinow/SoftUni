
using System;
//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
class BitsExchange
{
    static void Main()
    {
        Console.Title = "Problem 15.* Bits Exchange";

        Console.Write("Enter a number= ");
        uint number = uint.Parse(Console.ReadLine());

        Console.Write("The binary representaion: ", number);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(24, '0'));

        Console.ResetColor();
        Console.Write("Number: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(number);
        Console.ResetColor();

        uint mask = 7; // 0111
        uint firstBits = (number & (mask << 3)) >> 3; // Take bits 3 4 5, and then they go back to the beginning
        uint secondBits = (number & (mask << 24)) >> 24; // Take bits 24 25 26, and then they go back to the beginning 
        number = number & ~(mask << 3);
        number = number & ~(mask << 24);
        number = number | (firstBits << 24);
        number = number | (secondBits << 3);

        Console.Write("Number: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(number);
        Console.ResetColor();

        Console.Write("The binary representaion: ", number);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(24, '0'));
        Console.ResetColor();
    }
}
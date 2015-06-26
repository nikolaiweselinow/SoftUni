using System;
//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.


class CheckAtBitAtGivenPos
{
    static void Main()
    {
        Console.Title = "Problem 13. Check a Bit at Given Position";

        Console.Write("Enter integer n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter bit at index: ");
        int position = int.Parse(Console.ReadLine());

        int bit = (n >> position) & 1;
        bool isBitOne = (bit == 1);

        Console.WriteLine("Binary representation: {0}", Convert.ToString(n, 2).PadLeft(16, '0'));
        Console.WriteLine("Is Bit position #{0} is 1? --->> {1} <<---", position, isBitOne);
    }
}

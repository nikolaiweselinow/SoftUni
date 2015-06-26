using System;
//Write an expression that extracts from given integer n the value of given bit at index p.
class ExtractBitFromInt
{
    static void Main()
    {
        Console.Title = "Problem 12. Extract Bit from Integer";

        Console.Write("Enter integer n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter bit at index: ");
        int position = int.Parse(Console.ReadLine());

        int bit = (n >> position) & 1;

        Console.WriteLine("Binary representation: {0}", Convert.ToString(n, 2).PadLeft(16, '0'));
        Console.WriteLine("Bit number #{0} is: {1}", position, bit);
    }
}

﻿using System;
//Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##). Use Windows Calculator to find its hexadecimal representation. Print the variable and ensure that the result is “254”.
class VariableInHex
{
    static void Main()
    {
        int numberInHex = 0xFE;
        Console.WriteLine(numberInHex);

        int number = 254;
        Console.WriteLine(Convert.ToString(number, 16));
    }
}

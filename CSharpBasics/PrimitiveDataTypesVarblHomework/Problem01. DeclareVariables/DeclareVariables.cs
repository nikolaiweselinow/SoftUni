﻿using System;
//Problem 1.	Declare Variables
//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure it will fit in it. Try to compile the code. Submit the source code of your Visual Studio project as part of your homework submission.

class DeclareVariables
{
    static void Main()
    {
        // 52130, -115, 4825932, 97, -10000       
     
        ushort firstVariable = 52130;
        sbyte secondVariable = -115;
        int thirdVariable = 4825932;
        byte fourthVariable = 97;
        short fifthVariable = -10000;

        Console.WriteLine("First number: {0}\nSecond number: {1}\nThird number: {2}\nFourth number: {3}\nFifth number: {4}", firstVariable, secondVariable, thirdVariable, fourthVariable, fifthVariable);
    
    }
}


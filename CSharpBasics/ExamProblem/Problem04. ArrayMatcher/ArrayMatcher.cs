﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArrayMatcher
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('\\');
        string leftArray = input[0];
        string rightArray = input[1];
        string command = input[2];

        List<char> result = new List<char>();

        switch (command)
        {
            case "join":
                for (int i = 0; i < leftArray.Length; i++)
                {
                    for (int j = 0; j < rightArray.Length; j++)
                    {
                        if (leftArray[i] == rightArray[j])
                        {
                            result.Add(leftArray[i]);
                        }
                    }
                }
                break;
            case "right exclude":
                for (int i = 0; i < leftArray.Length; i++)
                {
                    bool isMatched = false;
                    for (int j = 0; j < rightArray.Length; j++)
                    {
                        if (leftArray[i] == rightArray[j])
                        {
                            isMatched = true;
                            break;                          
                        }
                        if (!isMatched)
                        {
                            result.Add(leftArray[i]);
                        }
                    }
                }
                break;
            case "left exclude":
                for (int i = 0; i < rightArray.Length; i++)
                {
                    bool isMatched = false;
                    for (int j = 0; j < leftArray.Length; j++)
                    {
                        if (leftArray[j] == rightArray[i])
                        {
                            isMatched = true;
                            break;
                        }
                        if (!isMatched)
                        {
                            result.Add(rightArray[i]);
                        }
                    }
                }
                break;
        }

        result.Sort();
        Console.WriteLine(string.Join("",result));
    }
}


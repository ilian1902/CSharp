﻿/*
 * Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##). 
 * Use Windows Calculator to find its hexadecimal representation. 
 * Print the variable and ensure that the result is “254”.
 */

using System;

class VariableHexadecimalFormat
{
    static void Main()
    {
        int number = 0xFE;

        Console.WriteLine("{0} in hexadecimal format is : {1:X}"
                                        , number, number);
    }
}
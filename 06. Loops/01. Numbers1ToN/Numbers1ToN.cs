﻿/*
 * Write a program that enters from the console a positive integer n 
 * and prints all the numbers from 1 to n, 
 * on a single line, separated by a space.
 */

using System;

class Numbers1ToN
{
    static void Main()
    {
        Console.WriteLine("Enter a number for N:");
        int counter = int.Parse(Console.ReadLine());

        for (int i = 1; i <= counter; i++)
        {
            Console.Write("{0} ", i);
        }
    }
}

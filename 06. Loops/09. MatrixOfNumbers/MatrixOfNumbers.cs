﻿/*
 * Write a program that reads from the console 
 * a positive integer number n (1 ≤ n ≤ 20) 
 * and prints a matrix like in the examples below. 
 * Use two nested loops. 
 * Examples:
 * 
    n	matrix
    2	1 2
        2 3
 * 
    n	matrix
    3	1 2 3
        2 3 4
        3 4 5
 * 
    n	matrix
    4	1 2 3 4
        2 3 4 5
        3 4 5 6
        4 5 6 7
 */

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a number [1-20]");
        int n = int.Parse(Console.ReadLine());

        if (n > 0 && n <= 20)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int coll = 0; coll < n; coll++)
                {
                    Console.Write("{0,2} ", coll + row);
                }
                Console.WriteLine();
            }
        }

        else
        {
            Console.WriteLine("The number must be bigger than 0 and lesser than 21");
        }
    }
}

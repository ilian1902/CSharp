/*
 * Write a program that reads from the console a positive integer number N (N < 20) 
 * and outputs a matrix like the following:
 *  N = 3	N = 4
 *  1 2 3   1 2 3 4
 *  2 3 4   2 3 4 5
 *  3 4 5   3 4 5 6
 *          4 5 6 7
 */

using System;
class Matrix
{
    static void Main()
    {
        Console.WriteLine("Enter a number [1-19]");
        int n = int.Parse(Console.ReadLine());

        if (n > 0 && n < 20)
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
            Console.WriteLine("The number must be bigger than 0 and lesser than 20");
        }
    }
}
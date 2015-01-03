/*
 * Write a program that calculates 
 * with how many zeroes the factorial 
 * of a given number n has at its end. 
 * Your program should work well for very big numbers, 
 * e.g. n=100000.
 */

using System;

class TrailingZeroesInN
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());

        int counter = 0;
        int divider = 5;
        while (n / divider >= 1)
        {
            counter += n / divider;
            divider *= 5;
        }
        Console.WriteLine("{0}! has {1} trailing zeros"
                            , n, counter);
    }
}

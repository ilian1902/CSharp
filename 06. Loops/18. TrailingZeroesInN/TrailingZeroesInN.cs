/*
 * Write a program that calculates 
 * with how many zeroes the factorial 
 * of a given number n has at its end. 
 * Your program should work well for very big numbers, 
 * e.g. n=100000. 
 * Examples:
n	    trailing zeroes of n!	explaination
10	    2	                    3628800
20	    4	                    2432902008176640000
100000	24999	                think why

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

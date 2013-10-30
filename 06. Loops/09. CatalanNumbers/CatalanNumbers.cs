/*
 * In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
 * (2*n)! / (n + 1)! * n!
 * Write a program to calculate the Nth Catalan number by given N.
 */

using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a Catalan number:");
        int n = int.Parse(Console.ReadLine());

        BigInteger divident = 1;
        BigInteger divider = 1;

        if (n > 0)
        {
            for (int i = 2 * n; i > n + 1; i--)
            {
                divident *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                divider *= i;
            }

            Console.WriteLine("The {0} Catalan number is: {1}", n, divident / divider);
        }
        else
        {
            Console.WriteLine("The number must be bigger than zero");
        }
    }
}
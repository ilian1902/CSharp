/*
 *In combinatorics, the Catalan numbers are calculated by the following formula:
  (2N)! / (N+1)! * N!
 * Write a program to calculate the nth Catalan number 
 * by given n (1 < n < 100). 
 * Examples:
    n	Catalan(n)
    0	1
    5	42
    10	16796
    15	9694845
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
        if (n > 0 && n < 100)
        {
            for (int i = 2 * n; i > n + 1; i--)
            {
                divident *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                divider *= i;
            }
            BigInteger result = divident / divider;
            Console.WriteLine("The {0} Catalan number is: {1}", n, result);
        }
        else
        {
            Console.WriteLine("The number must be bigger than zero");
        }
    }
}

/*
 * Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. 
 * Examples:
    n	            IsPrime(n)
    0	            false
    1	            false
    2	            true
    3	            true
    4	            false
    5	            true
    323	            false
    337	            true
    6737626471	    true
    117342557809	false
 */

using System;

class PrimeChecker
{
    static void Main()
    {
        Console.WriteLine("Enter an Integer number:");
        int n = int.Parse(Console.ReadLine());

        bool prime = IsPrime(n);
        Console.WriteLine(prime);
    }

    private static bool IsPrime(int n)
    {
        bool prime = false;

        if (( n == 2 || n == 3 || n == 5 || n == 7)
               ^ (n % 2 != 0 && n % 3 != 0 && n % 5 != 0 && n % 7 != 0))
        {
            prime = true;
        }
        else
        {
            prime = false;
        }
        return prime;
    }
}
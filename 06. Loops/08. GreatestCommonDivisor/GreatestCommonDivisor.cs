/*
 * Write a program that calculates the greatest common divisor 
 * (GCD) of given two numbers. 
 * Use the Euclidean algorithm (find it in Internet).
 */

using System;
class GreatestCommonDivisor
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int bigger = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int lesser = int.Parse(Console.ReadLine());

        Console.Write("The greatest common divisor of {0} and {1} is: "
                        , bigger, lesser);

        if (bigger < lesser)
        {
            bigger = bigger + lesser;
            lesser = bigger - lesser;
            bigger = bigger - lesser;
        }

        int divisor = (bigger % lesser);

        while (divisor != 0)
        {
            bigger = lesser;
            lesser = divisor;
            divisor = bigger % lesser;
        }

        Console.WriteLine(lesser);
    }
}
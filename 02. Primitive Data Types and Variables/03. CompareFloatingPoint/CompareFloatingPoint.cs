/*
 * Write a program that safely compares floating-point numbers
 * with precision of 0.000001.
 */

using System;
class CompareFloatingPoint
{
    static void Main()
    {

        Console.WriteLine("Enter the first Decimal number :");
        decimal first = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second Decimal number :");
        decimal second = decimal.Parse(Console.ReadLine());

        bool equal = first == second;
        bool greater = first > second;

        Console.WriteLine(equal ?
                            "The numbers are equal"
                            : "The numbers are NOT equal");

        if (equal == false)
        {
            Console.WriteLine(greater ?
                                "{0} is bigger than {1}"
                                : "{1} is bigger than {0}"
                                , first, second);
        }
    }
}
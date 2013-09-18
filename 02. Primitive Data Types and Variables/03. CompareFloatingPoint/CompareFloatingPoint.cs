//Write a program that safely compares floating-point numbers 
//with precision of 0.000001.
using System;
class CompareFloatingPoint
{
    static void Main()
    {
        decimal first;
        decimal second;

        Console.WriteLine("Enter the first Decimal number :");
        first = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second Decimal number :");
        second = decimal.Parse(Console.ReadLine());

        bool equal = first == second;
        Console.WriteLine(equal ? "The numbers are equal" : "The numbers are NOT equal");

        if (equal == false)
        {
            bool greater = first > second;
            Console.WriteLine(greater ? "{0} is bigger than {1}" : "{1} is bigger than {0}", first, second);
        }
    }
}
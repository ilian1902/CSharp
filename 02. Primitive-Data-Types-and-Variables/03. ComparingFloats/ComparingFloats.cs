﻿/*
 * Write a program that safely compares floating-point numbers 
 * with precision eps = 0.000001. 
 * Note that we cannot directly compare two floating-point numbers 
 * a and b by a==b because of the nature of the floating-point arithmetic. 
 * Therefore, we assume two numbers are equal 
 * if they are more closely to each other than a fixed constant eps. 
 * Examples:
Number a	Number b	Equal (with precision eps=0.000001)	Explanation
5.3	        6.01	    false	The difference of 0.71 is too big (> eps)
5.00000001	5.00000003	true	The difference 0.00000002 < eps
-0.0000007	0.00000007	true	The difference 0.00000077 < eps
-4.999999	-4.999998	false	Border case. The difference 0.000001 == eps. We consider the numbers are different.
 */

using System;

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Enter the first floating point number :");
        Decimal first = Decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second floating point number :");
        Decimal second = Decimal.Parse(Console.ReadLine());

        Decimal difference = Math.Abs(first - second);
        Decimal eps = 0.000001m;

        bool notEqual = difference >= eps;
        bool greater = first > second;

        Console.WriteLine(notEqual ?
            "The numbers are NOT equal" :
            "The numbers are equal");

        if (notEqual)
        {
            Console.WriteLine(greater ?
                "{0} is bigger than {1}" :
                "{1} is bigger than {0}"
                , first, second);
        }
    }
}

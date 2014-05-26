/*
 * Write a program that enters 3 real numbers and prints them sorted in descending order. 
 * Use nested if statements. Don’t use arrays and the built-in sorting functionality. 
 * Examples:
a	    b	    c	    result
5	    1	    2	    5 2 1
-2	    -2	    1	    1 -2 -2
-2	    4	    3	    4 3 -2
0	    -2.5	5	    5 0 -2.5
-1.1	-0.5	-0.1	-0.1 -0.5 -1.1
10	    20	    30	    30 20 10
1	    1	    1	    1 1 1
 */

using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        Console.WriteLine("Enter the first number");
        double first = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number");
        double second = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number");
        double third = double.Parse(Console.ReadLine());

        if (third > second)
        {
            third = third + second;
            second = third - second;
            third = third - second;
        }
        if (third > first)
        {
            third = third + first;
            first = third - first;
            third = third - first;
        }
        if (second > first)
        {
            second = second + first;
            first = second - first;
            second = second - first;
        }
        Console.WriteLine("{0} {1} {2}", first, second, third);
    }
}

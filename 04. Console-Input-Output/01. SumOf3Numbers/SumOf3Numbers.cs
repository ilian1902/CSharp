/*
 * Write a program that reads 3 real numbers from the console and prints their sum. 
 * Examples:
a	    b	    c	    sum
3	    4	    11	    18
-2	    0	    3	    1
5.5	    4.5	    20.1	30.1
 */

using System;

class SumOf3Numbers
{
    static void Main()
    {

        Console.WriteLine("Enter the first real number");
        decimal first = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second real number");
        decimal second = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third real number");
        decimal third = decimal.Parse(Console.ReadLine());

        decimal sum = first + second + third;

        Console.WriteLine("The Sum of the real number is : {0}", sum);
    }
}

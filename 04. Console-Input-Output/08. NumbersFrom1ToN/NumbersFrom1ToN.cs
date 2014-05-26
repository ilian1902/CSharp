/*
 * Write a program that reads an integer number n 
 * from the console and prints all the numbers in the interval [1..n], 
 * each on a single line. 
 * Note that you may need to use a for-loop. 
 * Examples:
numbers	sum     
3	    1
        2
        3
numbers	sum
5	    1
        2
        3
        4
        5
numbers	sum
1	    1
 */

using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

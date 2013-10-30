/*
 * Write a program that prints all the numbers from 1 to N, 
 * that are not divisible by 3 and 7 at the same time.
 */

using System;
class OneToNDivisible
{
    static void Main()
    {
        Console.WriteLine("Enter a number for N:");
        int counter = int.Parse(Console.ReadLine());

        for (int i = 1; i <= counter; i++)
        {
            if (i % 21 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
/*
 * Write a program that prints the first 10 members of the sequence: 
 * 2, -3, 4, -5, 6, -7, ...
 */

using System;

class Sequence
{
    static void Main()
    {
        byte counter = 10;

        for (int i = 2; i <= counter; i++)
        {
            Console.WriteLine(i);
            i++;
            Console.WriteLine(-i);
        }
    }
}

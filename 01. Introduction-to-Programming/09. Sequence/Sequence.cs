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
        byte start = 2;

        for (int i = start; i < start + counter; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(-i);
            }
        }
    }
}

/*
 * Write a program that prints the first 1000 members of the sequence: 
 * 2, -3, 4, -5, 6, -7, … 
 */

using System;

class LongSequence
{
    static void Main()
    {
        int counter = 1000;
        int startNumber = 2;

        Console.SetBufferSize(100, counter + startNumber);

        for (int i = startNumber; i < counter + startNumber; i++)
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

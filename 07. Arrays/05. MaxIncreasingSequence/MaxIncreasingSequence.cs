/*
 * Write a program that finds the maximal increasing sequence in an array.
 */

using System;
class MaxIncreasingSequence
{
    static void Main()
    {
        int[] array = { 3, 2, 3, 4, 2, 2, 4 };

        int sequence = 0;
        int maxSequence = 0;
        int lastElement = 0;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] + 1 == (array[i + 1]))
            {
                sequence++;
                lastElement = array[i] + 1;
            }
            else
            {
                sequence = 1;
            }

            if (sequence > maxSequence)
            {
                maxSequence = sequence;
            }
        }

        //Print Result
        int firstElement = lastElement - maxSequence + 1;
        for (int i = 1; i <= maxSequence; i++, firstElement++)
        {

            if (i != maxSequence)
            {
                Console.Write("{0},", firstElement);
            }
            else
            {
                Console.WriteLine("{0}", firstElement);
            }
        }
    }
}
/*
 * Write a program that finds the maximal sequence of equal elements in an array.
 * Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
 */

using System;
class MaximalEqualSequence
{
    static void Main()
    {
        int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

        int sequence = 0;
        int maxSequence = 0;
        int element = 0;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                sequence++;
            }
            else
            {
                sequence = 1;
            }

            if (sequence > maxSequence)
            {
                maxSequence = sequence;
                element = array[i];
            }
        }

        //Print Result
        for (int i = 1; i <= maxSequence; i++)
        {

            if (i != maxSequence)
            {
                Console.Write("{0},", element);
            }
            else
            {
                Console.WriteLine("{0}", element);
            }
        }

    }
}
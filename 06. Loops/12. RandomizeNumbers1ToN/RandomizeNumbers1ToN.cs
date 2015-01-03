/*
 * Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
 * You might need to use arrays.
 */

using System;

class RandomizeNumbers1ToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] pool = new int[n];
        bool[] printed = new bool[n + 1];
        Random r = new Random();
        int randomized = r.Next(1, n + 1);

        for (int index = 0; index < n; index++)
        {
            randomized = r.Next(1, n + 1);
            if (!printed[randomized])
            {
                Console.Write("{0} ", randomized);
                printed[randomized] = true;
            }
            else
            {
                index--;
            }
        }
        Console.WriteLine();
    }
}

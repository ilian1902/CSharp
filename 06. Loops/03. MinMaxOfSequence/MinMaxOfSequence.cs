/*
 * Write a program that reads from the console a sequence of N integer numbers 
 * and returns the minimal and maximal of them.
 */

using System;
class MinMaxOfSequence
{
    static void Main()
    {
        int input;
        int maxValue = int.MinValue;
        int minValue = int.MaxValue;

        Console.WriteLine("Enter how many numbers will be the sequence");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Enter the {0} number", i + 1);
            input = int.Parse(Console.ReadLine());

            if (input > maxValue)
            {
                maxValue = input;
            }
            if (input < minValue)
            {
                minValue = input;
            }
        }

        Console.WriteLine("The minimal value is: {0}\nThe maximal value is: {1}"
                            , minValue, maxValue);
    }
}
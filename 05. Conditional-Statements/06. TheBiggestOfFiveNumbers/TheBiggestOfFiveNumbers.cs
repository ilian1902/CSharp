/*
 * Write a program that finds the biggest of five numbers 
 * by using only five if statements.
 */

using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        double biggest = double.MinValue;
        double current;
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Enter the {0} number", i);
            current = double.Parse(Console.ReadLine());
            if (current > biggest)
            {
                biggest = current;
            }
        }
        Console.WriteLine("The biggest number is: {0}", biggest);
    }
}

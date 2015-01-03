/*
 * Write a program that gets two numbers from the console 
 * and prints the greater of them. 
 * Try to implement this without if statements.
 */

using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Enter the first number");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        double second = double.Parse(Console.ReadLine());

        // Using Math.Max
        double max = Math.Max(first, second);
        Console.WriteLine("The greater number is: {0}\n", max);

        // Using Math.Abs
        double absMax = ((first + second + Math.Abs(first - second)) / 2);
        Console.WriteLine("The greater number is: {0}", absMax);
    }
}

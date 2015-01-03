/*
 * Write a program that enters 5 numbers 
 * (given in a single line, separated by a space), 
 * calculates and prints their sum.
 */

using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter 5 numbers (given in a single line, separated by a space) :");
        string strNumbers = Console.ReadLine();
        double sum = 0;
        string[] Numbers = strNumbers.Split(new char[] { '\u0020' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < Numbers.Length; i++)
        {
            sum += double.Parse(Numbers[i]);
        }

        Console.WriteLine("Sum: {0}", sum);
    }
}

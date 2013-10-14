/*
 * Write a boolean expression that returns if the bit at position p (counting from 0) 
 * in a given integer number v has value of 1.
 */

using System;
class BitPositionCheck
{
    static void Main()
    {
        Console.WriteLine("Enter an Integer Number:");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit's position:");
        int p = int.Parse(Console.ReadLine());

        int bitChecker = 1;
        int check = ((v >> p) & bitChecker);
        bool result = check == 1;

        Console.WriteLine("The bit on position {0} has value of 1 is {1}"
                            , p, result);
    }
}
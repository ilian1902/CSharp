/*
 * Write a Boolean expression that returns if the bit at position p 
 * (counting from 0, starting from the right) 
 * in given integer number n has value of 1. 
 */

using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter an Integer Number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit's position:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("The binary representation of the {0} is:\n{1}",
                             n,
                             Convert.ToString(n, 2).PadLeft(16, '0'));

        int bitChecker = 1;
        int check = ((n >> p) & bitChecker);
        bool isOne = (check & bitChecker) == 1;

        Console.WriteLine("The bit on position {0} has value of 1: {1}", p, isOne);
    }
}

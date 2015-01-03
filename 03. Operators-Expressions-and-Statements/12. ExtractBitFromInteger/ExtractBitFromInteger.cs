/*
 * Write a Boolean expression that returns if the bit at position p 
 * (counting from 0, starting from the right) 
 * in given integer number n has value of 1.
 */

using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("Enter an Integer number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit's position:");
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine("The binary representation of the {0} is:\n{1}",
                             number,
                             Convert.ToString(number, 2).PadLeft(16, '0'));

        int bitChecker = 1 << position;

        Console.WriteLine((number & bitChecker) == bitChecker ?
                            "The bit in position {0} is: 1 " :
                            "The bit in position {0} is: 0"
                            , position);
    }
}

/*
 * Write a Boolean expression that returns if the bit at position p 
 * (counting from 0, starting from the right) 
 * in given integer number n has value of 1. 
 * Examples:
n	    binary representation of n	p	bit @ p == 1
5	    00000000 00000101	        2	true
0	    00000000 00000000	        9	false
15	    00000000 00001111	        1	true
5343	00010100 11011111	        7	true
62241	11110011 00100001	        11	false

 */

using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter an Integer Number:");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit's position:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("The binary representation of the {0} is:\n{1}",
                             i,
                             Convert.ToString(i, 2).PadLeft(16, '0'));

        int bitChecker = 1;
        int check = ((i >> b) & bitChecker);

        Console.WriteLine("The bit on position {0} has value of: {1}"
                            , b, ((check & bitChecker) != 0 ? "1 true" : "0 false"));
    }
}

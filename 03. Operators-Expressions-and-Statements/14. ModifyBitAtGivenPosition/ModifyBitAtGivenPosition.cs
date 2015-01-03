/*
 * We are given an integer number n, a bit value v (v=0 or 1) and a position p. 
 * Write a sequence of operators (a few lines of C# code) 
 * that modifies n to hold the value v at the position p 
 * from the binary representation of n while preserving all other bits in n.
 */

using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter an Integer Number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit's position:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value:");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("The binary representation of the {0} is:\n{1}",
                         n,
                         Convert.ToString(n, 2).PadLeft(16, '0'));

        int mask = 1 << p;

        if (v == 0)
        {
            n = n & (~mask);
            Console.WriteLine("Binary result is:\n{0}\nand now has value of: {1}",
                Convert.ToString(n, 2).PadLeft(16, '0'), n);

        }
        else // (value == 1)
        {
            n = n | mask;
            Console.WriteLine("Binary result is:\n{0}\nand now has value of: {1}",
                Convert.ToString(n, 2).PadLeft(16, '0'), n);
        }
    }
}

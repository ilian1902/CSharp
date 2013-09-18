//We are given integer number n, value v (v=0 or 1) and a position p. 
//Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
using System;
class SetBitValue
{
    static void Main()
    {
        Console.WriteLine("Enter an Integer Number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit's position:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value:");
        int v = int.Parse(Console.ReadLine());

        int mask = 1 << p;

        if (v == 0)
        {
            n = n & (~mask);
            Console.WriteLine("Number's new value is: {0}", n);
            Console.WriteLine((Convert.ToString(n, 2).PadLeft(32, '0')));
        }
        else //(value == 1)
        {
            n = n | mask;
            Console.WriteLine("Number's new value is: {0}", n);
            Console.WriteLine((Convert.ToString(n, 2).PadLeft(32, '0')));
        }
    }
}
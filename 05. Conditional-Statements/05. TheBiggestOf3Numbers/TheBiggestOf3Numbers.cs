/*
 * Write a program that finds the biggest of three numbers. 
 * Examples:
a	    b	    c	    biggest
5	    2	    2	    5
-2	    -2	    1	    1
-2	    4	    3	    4
0	    -2.5    5	    5
-0.1	-0.5	-1.1	-0.1
 */

using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        double biggest = double.MinValue;
        double current;
        for (int i = 1; i <= 3; i++)
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

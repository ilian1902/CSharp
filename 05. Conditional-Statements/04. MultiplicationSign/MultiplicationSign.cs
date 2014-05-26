/*
 * Write a program that shows the sign (+, - or 0) 
 * of the product of three real numbers, without calculating it. 
 * Use a sequence of if operators. 
 * Examples:
a	    b	    c	    result
5	    2	    2	    +
-2	    -2	    1	    +
-2	    4	    3	    -
0	    -2.5	4	    0
-1	    -0.5	-5.1	-
 */

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Enter the first number");
        double first = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number");
        double second = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number");
        double third = double.Parse(Console.ReadLine());

        int signCounter = 0;

        if ((first == 0) || (second == 0) || (third == 0))
        {
            Console.WriteLine("The product is 0");
        }

        else
        {
            if (first < 0)
            {
                signCounter++;
            }
            if (second < 0)
            {
                signCounter++;
            }
            if (third < 0)
            {
                signCounter++;
            }

            if (signCounter % 2 == 0)
            {
                Console.WriteLine("The sign of the product is + ");
            }
            else
            {
                Console.WriteLine("The sign of the product is - ");
            }
        }
    }
}

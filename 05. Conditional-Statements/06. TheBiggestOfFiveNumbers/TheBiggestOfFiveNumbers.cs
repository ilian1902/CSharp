/*
 * Write a program that finds the biggest of five numbers 
 * by using only five if statements. 
 * Examples:
a	b	    c	    d	    e	    biggest
5	2	    2	    4	    1	    5
-2	-22	    1	    0	    0	    1
-2	4	    3	    2	    0	    4
0	-2.5    0	    5	    5	    5
-3	-0.5    -1.1	-2	    -0.1	-0.1
 */

using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        double entered;
        double greatestNumber = double.MinValue;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter the {0} number:", i + 1);

            entered = double.Parse(Console.ReadLine());

            if (entered > greatestNumber)
            {
                greatestNumber = entered;
            }
        }
        Console.WriteLine("The greatest number You have entered is: {0}"
                            , greatestNumber);
    }
}

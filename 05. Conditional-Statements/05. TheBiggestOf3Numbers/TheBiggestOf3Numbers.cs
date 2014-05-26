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
        Console.WriteLine("Enter the first number");
        double first = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number");
        double second = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number");
        double third = double.Parse(Console.ReadLine());


        if (first > second && first > third)
        {
            Console.WriteLine("The biggest number is : {0}"
                                , first);
        }
        if (second > first && second > third)
        {
            Console.WriteLine("The biggest number is : {0}"
                                , second);
        }
        if (third > first && third > second)
        {
            Console.WriteLine("The biggest number is : {0}"
                                , third);
        }

        if ((first == second) && first > third)
        {
            Console.WriteLine("The biggest number is : {0} and it is equal to {1}"
                                , first, second);
        }

        if ((first == third) && first > second)
        {
            Console.WriteLine("The biggest number is :{0} and it is equal to {1}"
                                , first, third);
        }

        if ((second == third) && second > first)
        {
            Console.WriteLine("The biggest number is :{0} and it is equal to {1}"
                                , second, third);
        }

        if ((first == second) && (first == third) && (second == third))
        {
            Console.WriteLine("All three numbers are equal: {0} = {1} = {2}"
                                , first, second, third);
        }
    }
}

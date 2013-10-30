/*
 * We are given 5 integer numbers. 
 * Write a program that checks if the sum of some subset of them is 0. 
 * Example: 3, -2, 1, 1, 8  1+1-2=0.
 */

using System;
class SubsetSum
{
    static void Main()
    {
        Console.WriteLine("Enter value of the first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of the second number:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of the third number:");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of the fourth number:");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of the fifth number:");
        int e = int.Parse(Console.ReadLine());

        int counter = 0;

        //1 digit check
        if (a == 0)
        {
            counter++;
        }
        if (b == 0)
        {
            counter++;
        }
        if (c == 0)
        {
            counter++;
        }
        if (d == 0)
        {
            counter++;
        }
        if (e == 0)
        {
            counter++;
        }

        //2 digit check
        if (a + b == 0)
        {
            counter++;
        }
        if (a + c == 0)
        {
            counter++;
        }
        if (a + d == 0)
        {
            counter++;
        }
        if (a + e == 0)
        {
            counter++;
        }
        if (b + c == 0)
        {
            counter++;
        }
        if (b + d == 0)
        {
            counter++;
        }
        if (b + e == 0)
        {
            counter++;
        }
        if (c + d == 0)
        {
            counter++;
        }
        if (c + e == 0)
        {
            counter++;
        }
        if (d + e == 0)
        {
            counter++;
        }

        //3 digit check
        if (a + b + c == 0)
        {
            counter++;
        }
        if (a + b + d == 0)
        {
            counter++;
        }
        if (a + b + e == 0)
        {
            counter++;
        }
        if (a + c + d == 0)
        {
            counter++;
        }
        if (a + c + e == 0)
        {
            counter++;
        }
        if (a + d + e == 0)
        {
            counter++;
        }
        if (b + c + d == 0)
        {
            counter++;
        }
        if (b + c + e == 0)
        {
            counter++;
        }
        if (b + d + e == 0)
        {
            counter++;
        }
        if (c + d + e == 0)
        {
            counter++;
        }

        //4 digit check
        if (a + b + c + d == 0)
        {
            counter++;
        }
        if (a + b + c + e == 0)
        {
            counter++;
        }
        if (a + b + d + e == 0)
        {
            counter++;
        }
        if (a + c + d + e == 0)
        {
            counter++;
        }
        if (b + c + d + e == 0)
        {
            counter++;
        }

        //5 digit check
        if (a + b + c + d + e == 0)
        {
            counter++;
        }

        //Display result
        if (counter >= 1)
        {
            Console.WriteLine("There are {0} subset sums, that are 0", counter);
        }
        else
        {
            Console.WriteLine("There are none subset sums, that are 0");
        }
    }
}
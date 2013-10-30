/*
 * Write a program that shows the sign (+ or -) 
 * of the product of three real numbers without calculating it. 
 * Use a sequence of if statements.
 */

using System;
class ShowSign
{
    static void Main()
    {
        Console.WriteLine("Enter the first integer");
        double first = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second integer");
        double second = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third integer");
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
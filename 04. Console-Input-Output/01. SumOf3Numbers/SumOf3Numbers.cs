/*
 * Write a program that reads 3 real numbers from the console and prints their sum.
 */

using System;

class SumOf3Numbers
{
    static void Main()
    {

        Console.WriteLine("Enter the first real number");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second real number");
        double second = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third real number");
        double third = double.Parse(Console.ReadLine());

        double sum = first + second + third;

        Console.WriteLine("The Sum of the real number is : {0}", sum);
    }
}

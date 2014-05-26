/*
 * Write a program that enters a number n 
 * and after that enters more n numbers and calculates and prints their sum. 
 * Note that you may need to use a for-loop. 
 * Examples:
numbers	sum
3       90
20
60
10
numbers	sum
5       6.5
2
-1
-0.5
4
2	
numbers	sum
1       1
1	
 */

using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter how many numbers You will enter: ");
        double n = double.Parse(Console.ReadLine());
        double sum = 0;

        for (double i = 0; i < n; i++)
        {
            Console.WriteLine("Enter a number");
            double value = double.Parse(Console.ReadLine());
            sum += value;
        }
        Console.WriteLine("The sum of the {0} numbers is {1}"
                            , n, sum);
    }
}

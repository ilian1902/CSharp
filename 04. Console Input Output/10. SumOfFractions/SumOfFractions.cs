/*
 * Write a program to calculate the sum (with accuracy of 0.001):
 * 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
 */

using System;
class SumOfFractions
{
    static void Main()
    {
        double sum = 1d;
        //to achieve the accuracy, the loop must stop at 1000 (1/1000=0.001)
        for (int i = 2; i <= 1000; i++)
        {
            sum += (1d / i);
            i++;
            sum -= (1d / i);
            //to avoid using second 'for' loop
            //the calculation of positive and negative numbers is made here
        }
        Console.WriteLine("The result is: {0:0.000}", sum);
    }
}
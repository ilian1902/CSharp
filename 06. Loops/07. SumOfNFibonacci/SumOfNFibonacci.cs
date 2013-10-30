/*
 * Write a program that reads a number N 
 * and calculates the sum of the first N members 
 * of the sequence of Fibonacci: 
 * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
 * Each member of the Fibonacci sequence 
 * (except the first two) is a sum of the previous two members.
 */

using System;
class SumOfNFibonacci
{
    static void Main()
    {
        Console.WriteLine("How many Fibonacci members will be calculated");
        int n = int.Parse(Console.ReadLine());

        decimal firstNumber = 0m;
        decimal secondNumber = 1m;
        decimal sum;
        decimal total = 0;

        for (int i = 0; i < n; i++)
        {
            total += firstNumber;

            sum = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = sum;
        }

        Console.WriteLine("The sum of the first {0} Fibonacci members is {1}"
                            , n, total);
    }
}
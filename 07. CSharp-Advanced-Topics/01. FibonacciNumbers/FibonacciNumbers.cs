/*
 * Define a method Fib(n) that calculates the nth Fibonacci number. 
 * Examples:
    n	Fib(n)
    0	1
    1	1
    2	2
    3	3
    4	5
    5	8
    6	13
    11	144
    25	121393
 */

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the Fibonacci number:");
        int n = int.Parse(Console.ReadLine());

        decimal nthMember = Fib(n);
        Console.WriteLine(nthMember);
    }

    private static decimal Fib(int n)
    {
        decimal firstNumber = 0m;
        decimal secondNumber = 1m;
        decimal sum;

        for (int i = 0; i < n; i++)
        {
            sum = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = sum;
        }

        return secondNumber;
    }
}

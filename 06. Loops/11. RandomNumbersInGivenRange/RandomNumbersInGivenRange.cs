/*
 * Write a program that enters 3 integers n, 
 * min and max (min ≤ max) and prints n random numbers 
 * in the range [min...max].
 */

using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.WriteLine("Enter how many numbers will be printed");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter minimal value");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter maximal value");
        int max = int.Parse(Console.ReadLine());

        Random r = new Random();
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", r.Next(min, max + 1));
        }
    }
}

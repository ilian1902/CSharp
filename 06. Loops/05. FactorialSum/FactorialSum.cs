/*
 * Write a program that, for a given two integer numbers n and x, 
 * calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. 
 * Use only one loop. 
 * Print the result with 5 digits after the decimal point.
 */

using System;

class FactorialSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        decimal xAtPowerN = 1.00m;
        decimal factorial = 1.00m;
        decimal sum = 1.00m;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            xAtPowerN *= x;
            sum += (factorial / xAtPowerN);
        }
        Console.WriteLine("{0 :F5}", sum);
    }
}

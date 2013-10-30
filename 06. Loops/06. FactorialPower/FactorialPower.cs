/*
 * Write a program that, for a given two integer numbers N and X,
 * calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN
 */

using System;
class FactorialPower
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

        Console.WriteLine(sum);
    }
}
//Write a program that calculates N!/K! for given N and K (1<K<N).

using System;
using System.Numerics;
class DivisionOfFactorial
{
    static void Main()
    {
        Console.WriteLine("Enter value of K > 1");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of N > K");
        int n = int.Parse(Console.ReadLine());

        BigInteger result = 1;

        if (1 < k && k < n)
        {
            for (int i = k + 1; i <= n; i++)
            {
                result *= i;
            }
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }

        Console.WriteLine("N!/!K = {0}", result);
    }
}
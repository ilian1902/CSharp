using System;
using System.Numerics;

// Debug version --> prints the calculation details; uses BigInteger

public class OddEvenJumps
{
    public static void Main()
    {
        string input = Console.ReadLine().ToLower().Replace(" ", "");
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());

        int oddCounter = 0;
        BigInteger oddResult = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 == 0)
            {
                // Odd number (we count from 1, not from 0)
                oddCounter++;
                if (oddCounter % oddJump == 0)
                {
                    Console.Write("* {0} {1} ", (int) input[i], input[i]);
                    oddResult *= input[i];
                }
                else
                {
                    Console.Write("+ {0} {1} ", (int)input[i], input[i]);
                    oddResult += input[i];
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine(oddResult);
        string oddSum = oddResult.ToString("X");
        oddSum = RemoveLeadingZeroes(oddSum);
        Console.WriteLine("Odd: " + oddSum);

        int evenCounter = 0;
        BigInteger evenResult = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 != 0)
            {
                // Even number (we count from 1, not from 0)
                evenCounter++;
                if (evenCounter % evenJump == 0)
                {
                    Console.Write("* {0} {1} ", (int)input[i], input[i]);
                    evenResult *= input[i];
                }
                else
                {
                    Console.Write("+ {0} {1} ", (int)input[i], input[i]);
                    evenResult += input[i];
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine(evenResult);
        string evenSum = evenResult.ToString("X");
        evenSum = RemoveLeadingZeroes(evenSum);
        Console.WriteLine("Even: " + evenSum);
    }

    static string RemoveLeadingZeroes(string num)
    {
        if (num != "0")
        {
            num = num.TrimStart('0');
        }
        return num;
    }
}

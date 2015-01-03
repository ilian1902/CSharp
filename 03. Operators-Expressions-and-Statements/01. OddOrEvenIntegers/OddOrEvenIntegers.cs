/*
 * Write an expression that checks if given integer is odd or even.
 */

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter an Integer");
        int n = int.Parse(Console.ReadLine());

        bool check = n % 2 == 0;

        Console.WriteLine("The integer is {0}"
                            , check ? "even" : "odd");
    }
}

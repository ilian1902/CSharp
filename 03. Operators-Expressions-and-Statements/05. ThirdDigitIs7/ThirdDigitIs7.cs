/*
 * Write an expression that checks for given integer 
 * if its third digit from right-to-left is 7.
 */

using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.WriteLine("Enter an Integer");
        int n = int.Parse(Console.ReadLine());

        bool isSeven = (n / 100) % 10 == 7;

        Console.WriteLine("{0}", isSeven ?
                        "The third digit is 7" :
                        "The third digit is Not 7");
    }
}

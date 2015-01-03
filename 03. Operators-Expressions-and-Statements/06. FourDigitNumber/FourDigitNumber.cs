/*
 * Write a program that takes as input a four-digit number in format abcd (e.g. 2011) 
 * and performs the following:
•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
•	Prints on the console the number in reversed order: dcba (in our example 1102).
•	Puts the last digit in the first position: dabc (in our example 1201).
•	Exchanges the second and the third digits: acbd (in our example 2101).
 * The number has always exactly 4 digits and cannot start with 0.
 */

using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a foor digit integer, without leading zeros");
        int n = int.Parse(Console.ReadLine());

        int d = n % 10;
        n = n / 10;
        int c = n % 10;
        n = n / 10;
        int b = n % 10;
        n = n / 10;
        int a = n % 10;

        int sum = a + b + c + d;

        Console.WriteLine("{0}    sum of digits", sum);
        Console.WriteLine("{0}{1}{2}{3} reversed", d, c, b, a);
        Console.WriteLine("{0}{1}{2}{3} last digit in front", d, a, b, c);
        Console.WriteLine("{0}{1}{2}{3} second and third digits exchanged", a, c, b, d);
    }
}

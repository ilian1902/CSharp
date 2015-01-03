/*
 * Write an if-statement that takes two integer variables a and b 
 * and exchanges their values if the first one is greater than the second one. 
 * As a result print the values a and b, separated by a space.
 */

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Enter the first variable");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second variable");
        double second = double.Parse(Console.ReadLine());

        if (first > second)
        {
            first = second + first;
            second = first - second;
            first = first - second;
        }
        Console.WriteLine("{0} {1}", first, second);
    }
}

/*
 * Write an if-statement that takes two integer variables a and b 
 * and exchanges their values if the first one is greater than the second one. 
 * As a result print the values a and b, separated by a space. 
 * Examples:
a	    b	    result
5	    2	    2 5
3	    4	    3 4
5.5	    4.5	    4.5 5.5
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

        if (first < second)
        {
            Console.WriteLine("The first {0} is lesser than the second {1}\n{0} {1}"
                                , first, second);
        }

        else
        {
            first = second + first;
            second = first - second;
            first = first - second;
            Console.WriteLine("The first {0} has exchanged its value with the second {1}\n{0} {1}"
                                , first, second);
        }
    }
}

/*
 * Write an if statement that examines two integer variables 
 * and exchanges their values if the first one is greater than the second one.
 */

using System;
class ExchangeTheGreater
{
    static void Main()
    {
        Console.WriteLine("Enter the first integer");
        int first = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second integer");
        int second = int.Parse(Console.ReadLine());

        if (first > second)
        {
            Console.WriteLine("The first {0} is greater than the second {1}"
                                , first, second);
        }

        else
        {
            second = first + second;
            first = second - first;
            second = second - first;
            Console.WriteLine("The first {0} has exchanged its value with the second {1}"
                                , first, second);
        }

    }
}


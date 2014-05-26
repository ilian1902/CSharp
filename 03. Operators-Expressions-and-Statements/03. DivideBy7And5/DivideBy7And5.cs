/*
 * Write a Boolean expression that checks for given integer 
 * if it can be divided (without remainder) by 7 and 5 in the same time. 
 * Examples:
n	Divided by 7 and 5?
3	false
0	false
5	false
7	false
35	true
140	true
 */

using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Enter an Integer Number:");
        int number = int.Parse(Console.ReadLine());

        bool isDivisible = (number % 35 == 0) && (number != 0);

        Console.WriteLine("The number is {0}"
                        , isDivisible ?
                        "divisible by 5 and 7 in the same time" :
                        "not  divisible by 5 and 7 in the same time");
    }
}

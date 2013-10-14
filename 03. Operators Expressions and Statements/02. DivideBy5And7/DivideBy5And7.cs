/*
 * Write a boolean expression that checks for given integer
 * if it can be divided (without remainder) by 7 and 5 in the same time.
 */

using System;
class DivideBy5And7
{
    static void Main()
    {
        Console.WriteLine("Enter an Integer Number:");
        int number = int.Parse(Console.ReadLine());
        bool isDivided = (number % 5 == 0) && (number % 7 == 0);
        string trueMessage = "The Number CAN be divided without remainder by 7 and 5 in the same time.";
        string falseMessage = "The Number CANNOT be divided without remainder by 7 and 5 in the same time.";

        Console.WriteLine(isDivided ? trueMessage : falseMessage);

        //5 and 7 don't have common dividers, so by multiplying them we can avoid the double check
        Console.WriteLine(number % 35 == 0 ? trueMessage : falseMessage);
    }
}
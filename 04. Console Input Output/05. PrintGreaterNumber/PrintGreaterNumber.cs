/*
 * Write a program that gets two numbers from the console and prints the greater of them. 
 * Don’t use if statements.
 */

using System;
class PrintGreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the first number to bring into comparison");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number to bring into comparison");
        int second = int.Parse(Console.ReadLine());

        //Using Math.Max
        int max = Math.Max(first, second);
        Console.WriteLine("The greater number is: {0}", max);

        //Using Math.Abs
        int absMax = ((first + second + Math.Abs(first - second)) / 2);
        int absMin = ((first + second - Math.Abs(first - second)) / 2);
        Console.WriteLine("The greater number is: {0}\nThe lesser number is: {1}"
                            , absMax, absMin);

        //Using Bitwise operation
        int bitMax = first - ((first - second) & ((first - second)) >> 31);
        Console.WriteLine("The greater number is: {0}"
                            , bitMax);

    }
}
/*
 * Write a program that gets two numbers from the console 
 * and prints the greater of them. 
 * Try to implement this without if statements. 
 * Examples:
a	b	greater
5	6	6
10	5	10
0	0	0
-5	-2	-2
1.5	1.6	1.6
 */

using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Enter the first number to bring into comparison");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number to bring into comparison");
        double second = double.Parse(Console.ReadLine());

        //Using Math.Max
        double max = Math.Max(first, second);
        Console.WriteLine("The greater number is: {0}\n", max);

        //Using Math.Abs
        double absMax = ((first + second + Math.Abs(first - second)) / 2);
        double absMin = ((first + second - Math.Abs(first - second)) / 2);
        Console.WriteLine("The greater number is: {0}\nThe lesser number is: {1}\n"
                            , absMax, absMin);
    }
}

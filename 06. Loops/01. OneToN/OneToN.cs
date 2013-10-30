//Write a program that prints all the numbers from 1 to N.

using System;
class OneToN
{
    static void Main()
    {
        Console.WriteLine("Enter a number for N:");
        int counter = int.Parse(Console.ReadLine());

        for (int i = 1; i <= counter; i++)
        {
            Console.WriteLine(i);
        }
    }
}
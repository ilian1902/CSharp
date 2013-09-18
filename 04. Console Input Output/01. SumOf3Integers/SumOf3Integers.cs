//Write a program that reads 3 integer numbers from the console and prints their sum.
using System;
class SumOf3Integers
{
    static void Main()
    {
        Console.WriteLine("Enter the first Integer");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second Integer");
        int second = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third Integer");
        int third = int.Parse(Console.ReadLine());

        Console.WriteLine("The Sum of the integers is : {0}", first + second + third);
    }
}
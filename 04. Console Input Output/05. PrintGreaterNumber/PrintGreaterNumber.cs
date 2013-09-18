//Write a program that gets two numbers from the console and prints the greater of them. 
//Don’t use if statements.
using System;
class PrintGreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the first number to bring into comparison");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number to bring into comparison");
        int second = int.Parse(Console.ReadLine());

        int max = Math.Max(first, second);
        Console.WriteLine("The greater number is: {0}", max);
    }
}
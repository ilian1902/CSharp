//Write a program that gets a number n 
//and after that gets more n numbers 
//and calculates and prints their sum.
using System;
class SumOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter how many numbers You will enter: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter a number");
            int value = int.Parse(Console.ReadLine());
            sum += value;
        }
        Console.WriteLine("The sum of the {0} numbers is {1}", n, sum);
    }
}
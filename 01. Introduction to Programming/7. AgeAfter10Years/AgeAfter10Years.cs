//* Write a program to read your age from the console and print how old you will be after 10 years.

using System;

class AgeAfter10Years
{
    static void Main()
    {
        int currentYear = DateTime.Now.Year;

        Console.WriteLine("Enter the age You are/will be this year {0}: ", currentYear);
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("After ten years, in {0} , You will be {1} years old"
                            , currentYear + 10, age + 10);
    }
}
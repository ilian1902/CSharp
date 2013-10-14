//* Write a program to read your age from the console and print how old you will be after 10 years.

using System;

class AgeAfter10Years
{
    static void Main()
    {
        int currentYear = DateTime.Now.Year;

        Console.WriteLine("Enter the age You are/will be this year: " + currentYear);
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("After ten years, in " + (currentYear + 10) +
                            ", You will be " + (age + 10) + " years old");
    }
}
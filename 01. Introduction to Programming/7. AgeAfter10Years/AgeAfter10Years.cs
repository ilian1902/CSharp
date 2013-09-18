//* Write a program to read your age from the console and print how old you will be after 10 years.

using System;

class AgeAfter10Years
{
    static void Main()
    {
        int bYear;
        int ageNow;

        Console.WriteLine("Enter the year You have been born: ");
        bYear = int.Parse(Console.ReadLine());
        ageNow = DateTime.Now.Year - bYear;

        if (1900 < bYear && bYear < DateTime.Now.Year)
        {
            Console.WriteLine("Now You are {0} years old\nAfter Ten years You will be {1} years old"
                                , ageNow, ageNow + 10);
        }
        else
        {
            Console.WriteLine("You have entered an invalid year");
        }

    }
}
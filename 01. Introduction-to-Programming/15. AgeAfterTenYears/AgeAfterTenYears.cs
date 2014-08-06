/*
 * Write a program to read your age from the console and print how old you will be after 10 years.
 */

using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Enter Your birthdate in the following format dd/mm/yyyy");
        string BDate = Console.ReadLine();

        DateTime BirthDay = DateTime.Parse(BDate);
        DateTime now = DateTime.Now;

        TimeSpan span = now - BirthDay;
        DateTime zeroTime = new DateTime(1, 1, 1);
        /*cannot enter zero value
        and later they will be reduced by 1*/
        DateTime interval = (zeroTime + span);

        int year = interval.Year - 1;
        int month = interval.Month - 1;
        int days = interval.Day - 1;
        /*for each part of the date need to distract one
        because they start from 1 instead of 0*/

        DateTime afterTen = interval.AddYears(9);
        int afterTenYears = afterTen.Year;

        Console.WriteLine("Now You are {0} years, {1} months, {2} days old"
                            , year, month, days);
        Console.WriteLine("After 10 years You will be {0} year old"
                            , afterTenYears);
    }
}

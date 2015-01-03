/*
 * A beer time is after 1:00 PM and before 3:00 AM. 
 * Write a program that enters a time in format “hh:mm tt” 
 * (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
 * and prints “beer time” or “non-beer time” according to the definition above 
 * or “invalid time” if the time cannot be parsed. 
 * Note that you may need to learn how to parse dates and times.
 */

using System;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine("Enter a time in format hh:mm tt");
        string input = Console.ReadLine();
        DateTime time;
        DateTime start = DateTime.Parse("1:00 PM");
        DateTime end = DateTime.Parse("3:00 AM");

        bool parsed = DateTime.TryParse(input, out time);
        if (parsed)
        {
            if (time >= start || time < end)
            {
                Console.WriteLine("Beer Time");
            }
            else
            {
                Console.WriteLine("Non beer Time");
            }
        }
        else
        {
            Console.WriteLine("You are already drunk");
        }
    }
}

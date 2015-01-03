using System;

class ExamSchedule
{
    static void Main()
    {
        int startingHour = int.Parse(Console.ReadLine());
        int startingMinutes = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();
        int durationHours = int.Parse(Console.ReadLine());
        int durationMinutes = int.Parse(Console.ReadLine());

        if (partOfDay.Equals("PM"))
        {
            startingHour += 12;
        }
        DateTime start = new DateTime(2014, 4, 12, startingHour, startingMinutes, 0);
        TimeSpan duration = new TimeSpan(0, durationHours, durationMinutes, 0);
        Console.WriteLine("{0:hh:mm:tt}", start + duration);
    }
}

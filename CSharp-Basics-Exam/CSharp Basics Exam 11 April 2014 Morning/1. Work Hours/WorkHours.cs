using System;

class WorkHours
{
    static void Main()
    {
        long projectHours = long.Parse(Console.ReadLine());
        int workDays = int.Parse(Console.ReadLine());
        double productivity = int.Parse(Console.ReadLine());

        double biking = workDays * 0.1;
        double workTime = workDays - biking;
        double work = (((workTime) * 12) * productivity) / 100;
        if (((int)work) - projectHours >= 0)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("{0}", ((int)work) - projectHours);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0}", ((int)work) - projectHours);
        }
    }
}
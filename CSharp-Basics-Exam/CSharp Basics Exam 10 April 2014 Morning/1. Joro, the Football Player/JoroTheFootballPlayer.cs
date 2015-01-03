using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        char leapInput = char.Parse(Console.ReadLine());
        int holidays = int.Parse(Console.ReadLine());
        int hometown = int.Parse(Console.ReadLine());
        bool leapYear = leapInput == 't';

        int weekendPlays = (52 - hometown) * 2 / 3;
        int plays = weekendPlays + hometown + (holidays / 2);
        if (leapYear)
        {
            plays += 3;
        }

        Console.WriteLine(plays);
    }
}

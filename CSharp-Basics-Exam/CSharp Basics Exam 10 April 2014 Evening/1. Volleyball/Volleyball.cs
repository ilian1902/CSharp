using System;

class Volleyball
{
    static void Main()
    {
        string leap = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int hometown = int.Parse(Console.ReadLine());

        double plays = (48 - hometown) * 3.0 / 4.0 + hometown + holidays * 2.0 / 3.0;
        if (leap.Equals("leap"))
        {
            plays += plays * 15 / 100;
        }
        Console.WriteLine((int)plays);
    }
}

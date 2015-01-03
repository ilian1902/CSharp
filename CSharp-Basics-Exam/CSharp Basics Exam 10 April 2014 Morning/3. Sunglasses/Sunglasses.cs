using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char frame = '*';
        char lens = '/';
        char bridge = '|';
        char space = ' ';

        Console.WriteLine(new string(frame, n * 2) + new string(space, n) + new string(frame, n * 2));
        for (int i = 0; i < n - 2; i++)
        {
            if (i == (n - 2) / 2)
            {
                Console.WriteLine(frame + new string(lens, n * 2 - 2) + frame + new string(bridge, n) + frame + new string(lens, n * 2 - 2) + frame);
            }
            else
            {
                Console.WriteLine(frame + new string(lens, n * 2 - 2) + frame + new string(space, n) + frame + new string(lens, n * 2 - 2) + frame);
            }

        }
        Console.WriteLine(new string(frame, n * 2) + new string(space, n) + new string(frame, n * 2));
    }
}

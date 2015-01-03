using System;

class Eclipse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char frame = '*';
        char lens = '/';
        char bridge = '-';
        char space = ' ';

        Console.WriteLine(
            space +
            new string(frame, n * 2 - 2) +
            new string(space, n + 1) +
            new string(frame, n * 2 - 2) +
            space);
        for (int i = 0; i < n - 2; i++)
        {
            if (i == (n - 2) / 2)
            {
                Console.WriteLine(
                    frame +
                    new string(lens, n * 2 - 2) +
                    frame +
                    new string(bridge, n - 1) +
                    frame +
                    new string(lens, n * 2 - 2) +
                    frame);
            }
            else
            {
                Console.WriteLine(
                    frame +
                    new string(lens, n * 2 - 2) +
                    frame +
                    new string(space, n - 1) +
                    frame +
                    new string(lens, n * 2 - 2) +
                    frame);
            }

        }
        Console.WriteLine(
            space +
            new string(frame, n * 2 - 2) +
            new string(space, n + 1) +
            new string(frame, n * 2 - 2) +
            space);
    }
}

using System;

class BitsInverter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int position = -1;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            for (int j = 7; j >= 0; j--)
            {
                position++;
                if (step == 1 || position % step == 0)
                {
                    num = num ^ (1 << j);
                }
            }
            Console.WriteLine(num);
        }
    }
}

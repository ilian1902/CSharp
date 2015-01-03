using System;

class BitsUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int position = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            for (int j = 7; j >= 0; j--)
            {
                if ((step == 1 && position > 0) || (position % step == 1))
                {
                    num = num | (1 << j);
                }
                position++;
            }
            Console.WriteLine(num);
        }
    }
}

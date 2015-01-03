using System;

class Pairs
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        int[] pairs = new int[numbers.Length / 2];
        for (int n = 1, p = 0; n < numbers.Length; n += 2, p++)
        {
            int first = int.Parse(numbers[n - 1]);
            int second = int.Parse(numbers[n]);
            pairs[p] = first + second;
        }
        int diff = 0;

        for (int i = 1; i < pairs.Length; i++)
        {
            if (diff < (Math.Abs(pairs[i - 1] - pairs[i])))
            {
                diff = Math.Abs(pairs[i - 1] - pairs[i]);
            }
        }

        if (diff == 0)
        {
            Console.WriteLine("Yes, value={0}", pairs[0]);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", diff);
        }
    }
}

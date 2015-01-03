using System;

class SumOfElements
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numS = input.Split(' ');
        long[] nums = new long[numS.Length];

        long sum = 0;
        bool noMatch = true;
        long minDiff = long.MaxValue;

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = long.Parse(numS[i]);
            sum += nums[i];
        }

        foreach (var num in nums)
        {
            if (num == sum - num)
            {
                Console.WriteLine("Yes, sum={0}", num);
                noMatch = false;
                break;
            }
            else
            {
                if (minDiff > Math.Abs((sum - num) - num))
                {
                    minDiff = Math.Abs((sum - num) - num);
                }
            }
        }

        if (noMatch)
        {
            Console.WriteLine("No, diff={0}", minDiff);
        }
    }
}

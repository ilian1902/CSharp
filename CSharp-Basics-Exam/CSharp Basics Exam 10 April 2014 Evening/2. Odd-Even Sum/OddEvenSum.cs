using System;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int oddSum = 0;
        int evenSum = 0;

        for (int i = 0; i < n * 2; i++)
        {
            if (i % 2 == 0)
            {
                evenSum += int.Parse(Console.ReadLine());
            }
            else
            {
                oddSum += int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("{0}", oddSum == evenSum ?
            "Yes, sum=" + oddSum :
            "No, diff=" + Math.Abs(oddSum - evenSum));
    }
}

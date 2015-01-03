using System;

class OddEvenElements
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] nums = input.Split(' ');

        decimal oddSum = 0;
        decimal oddMax = decimal.MinValue;
        decimal oddMin = decimal.MaxValue;
        decimal evenSum = 0;
        decimal evenMax = decimal.MinValue;
        decimal evenMin = decimal.MaxValue;

        if (input == "")
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
        else if (nums.Length == 1 && nums[0] != "")
        {
            Console.WriteLine("OddSum={0:0.##}, OddMin={0:0.##}, OddMax={0:0.##}, EvenSum=No, EvenMin=No, EvenMax=No", decimal.Parse(nums[0]));
        }
        else if (nums.Length > 1)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                decimal currentNumber = decimal.Parse(nums[i]);
                if (i % 2 == 0)
                {
                    if (currentNumber > oddMax)
                    {
                        oddMax = currentNumber;
                    }
                    if (currentNumber < oddMin)
                    {
                        oddMin = currentNumber;
                    }
                    oddSum += currentNumber;
                }
                else if (i % 2 == 1)
                {
                    if (currentNumber > evenMax)
                    {
                        evenMax = currentNumber;
                    }
                    if (currentNumber < evenMin)
                    {
                        evenMin = currentNumber;
                    }
                    evenSum += currentNumber;
                }
            }
            Console.WriteLine("OddSum={0:0.##}, OddMin={1:0.##}, OddMax={2:0.##}, EvenSum={3:0.##}, EvenMin={4:0.##}, EvenMax={5:0.##}"
                           , oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
        }
    }
}

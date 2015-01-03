using System;

class CrossingSequences
{
    static void Main()
    {
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        decimal thirdNumber = decimal.Parse(Console.ReadLine());
        decimal sum = firstNumber + secondNumber + thirdNumber;

        int spiralnum = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        bool isFound = false;
        int stepIncrease = 0;
        bool toIncrease = false;

        while (thirdNumber <= 1000000)
        {
            while (firstNumber >= spiralnum || secondNumber >= spiralnum || thirdNumber >= spiralnum)
            {
                if (firstNumber == spiralnum || secondNumber == spiralnum || thirdNumber == spiralnum)
                {
                    Console.WriteLine(spiralnum);
                    isFound = true;
                    return;
                }

                spiralnum += step * stepIncrease;
                if (toIncrease)
                {
                    stepIncrease++;
                }
                toIncrease = !toIncrease;
            }

            firstNumber = secondNumber;
            secondNumber = thirdNumber;
            thirdNumber = sum;
            sum = firstNumber + secondNumber + thirdNumber;
        }
        if (!isFound)
        {
            Console.WriteLine("No");
        }
    }
}

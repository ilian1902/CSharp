//Write a program that finds the greatest of given 5 variables.

using System;
class GreatestOfFive
{
    static void Main()
    {
        double entered;
        double greatestNumber = double.MinValue;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter the {0} number:"
                                , i + 1);

            entered = double.Parse(Console.ReadLine());

            if (entered > greatestNumber)
            {
                greatestNumber = entered;
            }
        }
        Console.WriteLine("The greatest number You have entered is: {0}"
                            , greatestNumber);
    }
}
/*
 * Write a program that reads two arrays from the console 
 * and compares them element by element.
 */

using System;
class CompareArrays
{
    static void Main()
    {
        bool areEqual = true;

        Console.WriteLine("Enter the lenght of the first array");
        int firstArrIndex = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the lenght of the second array");
        int secondArrIndex = int.Parse(Console.ReadLine());

        if (firstArrIndex == secondArrIndex)
        {
            int[] firstArray = new int[firstArrIndex];
            int[] secondArray = new int[secondArrIndex];

            for (int i = 0; i < firstArrIndex; i++)
            {
                Console.WriteLine("Enter the value for the {0} element of the first array"
                                    , i + 1);
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < firstArrIndex; i++)
            {
                Console.WriteLine("Enter the value for the {0} element of the second array"
                                    , i + 1);
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < firstArrIndex; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                    break;
                }
            }
        }
        else
        {
            areEqual = false;
        }

        Console.WriteLine("The Arrays are {0}", areEqual
                            ? "equal"
                            : "not equal");
    }
}
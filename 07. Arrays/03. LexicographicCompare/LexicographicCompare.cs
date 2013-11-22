/*
 * Write a program that compares two char arrays lexicographically (letter by letter).
 */

using System;
class LexicographicCompare
{
    static void Main()
    {
        Console.WriteLine("Enter the first set of chars for comparison:");
        string firstStr = Console.ReadLine();
        Console.WriteLine("Enter the second set of chars for comparison:");
        string secondStr = Console.ReadLine();

        char[] firstArray = firstStr.ToCharArray();
        int firstArrayLength = firstArray.Length;

        char[] secondArray = secondStr.ToCharArray();
        int secondArrayLength = secondArray.Length;

        int arrLenght = Math.Min(secondArrayLength, firstArrayLength);

        for (int i = 0; i < arrLenght; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("{0} is lexicographically before {1}"
                                        , firstStr, secondStr);
                    break;
                }
                else
                {
                    Console.WriteLine("{0} is lexicographically before {1}"
                                        , secondStr, firstStr);
                    break;
                }
            }
            else
            {
                Console.WriteLine("The arrays are lexicographically equal");
            }
        }
    }
}
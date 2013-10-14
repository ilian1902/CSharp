//Create a console application that calculates and prints the square of the number 12345.

using System;

class SquareOf12345
{
    static void Main()
    {
        int number = 12345;

        Console.WriteLine(number * number);

        //or the other method

        double sq = Math.Pow(number, 2);
        Console.WriteLine(sq);
    }
}
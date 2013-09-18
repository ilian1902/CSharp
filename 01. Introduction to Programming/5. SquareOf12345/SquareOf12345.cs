//Create a console application that calculates and prints the square of the number 12345.

using System;

class SquareOf12345
{
    static void Main()
    {
        Console.WriteLine(12345 * 12345);

        //Or the other method

        double sq = Math.Pow(12345, 2);
        Console.WriteLine(sq);
    }
}
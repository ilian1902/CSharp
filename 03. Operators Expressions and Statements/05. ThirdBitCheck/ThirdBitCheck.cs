//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
using System;
class ThirdBitCheck
{
    static void Main()
    {
        Console.WriteLine("Enter an Integer number");
        int number = int.Parse(Console.ReadLine());
        int checker = 8;
        //binary representation of 8 is 1000, 
        //the third bit(counting from 0) is 1 and the others are zeros, 
        //which suits to this bool '&' check

        Console.WriteLine((number & checker) == 8 ? "The Third bit is 1 " : "The Third bit is 0");
    }
}
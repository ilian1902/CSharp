/*
 * Write a program that exchanges bits 3, 4 and 5 
 * with bits 24, 25 and 26 of given 32-bit unsigned integer.
 */

using System;

class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("Enter Unsigned Integer number:");
        uint number = uint.Parse(Console.ReadLine());

        Console.WriteLine("The binary represantation of {0} is: \n{1}",
                             number,
                             Convert.ToString(number, 2).PadLeft(32, '0'));

        uint maskFirst = 56u;       // 0000 0000 0000 0000 0000 0000 0011 1000
        uint maskLast = 117440512u; // 0000 0111 0000 0000 0000 0000 0000 0000
        // Extracting and saving values of the bits
        uint first3Bits = number & maskFirst;
        uint last3Bits = number & maskLast;
        // Shifting bits to needed positions (24-3, 25-4, 26-5 = 21)
        first3Bits = first3Bits << 21;
        last3Bits = last3Bits >> 21;
        // Setting 0 in those position of the given number
        number = number & (~maskFirst);
        number = number & (~maskLast);
        // Applying extracted values
        number = number | first3Bits;
        number = number | last3Bits;

        Console.WriteLine("Binary result is:\n{0}\nResult: {1}"
                            , Convert.ToString(number, 2).PadLeft(32, '0')
                            , number);
    }
}

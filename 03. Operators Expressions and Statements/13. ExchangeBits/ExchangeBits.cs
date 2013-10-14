//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;
class ExchangeBits
{
    static void Main()
    {
        Console.WriteLine("Enter Unsigned Integer number[0-256]:");
        uint number = uint.Parse(Console.ReadLine());
        uint maskFirst = 56u;        // 0000 0000 0000 0000 0000 0000 0011 1000
        uint maskLast = 117440512u;  // 0000 0111 0000 0000 0000 0000 0000 0000
        Console.WriteLine("The binary represantation of the number is: \n"
                            + Convert.ToString(number, 2).PadLeft(32, '0'));
        uint first3Bits = number & maskFirst;
        uint last3Bits = number & maskLast;

        first3Bits = first3Bits << 21;
        last3Bits = last3Bits >> 21;

        number = number & (~maskFirst);
        number = number & (~maskLast);

        number = number | first3Bits;
        number = number | last3Bits;

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
/*
 * Write a program that exchanges bits 3, 4 and 5 
 * with bits 24, 25 and 26 of given 32-bit unsigned integer. 
 * Examples:
n	        binary representation of n	            binary result	                        result
1140867093	01000100 00000000 01000000 00010101	    01000010 00000000 01000000 00100101	    1107312677
255406592	00001111 00111001 00110010 00000000	    00001000 00111001 00110010 00111000	    137966136
4294901775	11111111 11111111 00000000 00001111	    11111001 11111111 00000000 00111111	    4194238527
5351	    00000000 00000000 00010100 11100111	    00000100 00000000 00010100 11000111	    67114183
2369124121	10001101 00110101 11110111 00011001	    10001011 00110101 11110111 00101001	    2335569705
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

        uint first3Bits = number & maskFirst;
        uint last3Bits = number & maskLast;

        first3Bits = first3Bits << 21;
        last3Bits = last3Bits >> 21;

        number = number & (~maskFirst);
        number = number & (~maskLast);

        number = number | first3Bits;
        number = number | last3Bits;

        Console.WriteLine("Integer's new binary representation is:\n{0}\nAnd now has value of:\n{1}"
                            , Convert.ToString(number, 2).PadLeft(32, '0')
                            , number);
    }
}

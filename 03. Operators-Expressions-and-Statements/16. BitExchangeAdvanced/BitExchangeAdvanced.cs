/*
 * Write a program that exchanges bits {p, p+1, …, p+k-1} 
 * with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. 
 * The first and the second sequence of bits may not overlap.
 */

using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        uint number = 0u;
        byte close = 0;
        byte far = 0;
        byte k = 0;


        Console.WriteLine("Enter Unsigned Integer number:");
        number = uint.Parse(Console.ReadLine());
        Console.WriteLine("The binary represantation of the number is: \n{0}"
                            , Convert.ToString(number, 2).PadLeft(32, '0'));

        Console.WriteLine("Enter the first position of the bits, that are going to be exchanged:");
        close = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second position of the bits, that are going to be exchanged:");
        far = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of the bits, that are going to be exchanged:");
        k = byte.Parse(Console.ReadLine());

        if (Math.Min(close, far) + k > Math.Max(close, far))
        {
            Console.WriteLine("Overlapping");
        }
        else if (!(((close + k) <= 32) && ((far + k) <= 32)))
        {
            Console.WriteLine("Out of range");
        }
        else
        {
            uint mask = (1u << k) - 1u;
            uint maskClose = mask << close;
            uint maskFar = mask << far;

            uint closeBits = number & maskClose;
            uint farBits = number & maskFar;

            closeBits = closeBits >> close;
            farBits = farBits >> far;

            number = number & (~maskClose);
            number = number & (~maskFar);

            closeBits = closeBits << far;
            farBits = farBits << close;

            number = number | closeBits;
            number = number | farBits;

            Console.WriteLine("Binary result:\n{0}\nResult:{1}"
                           , Convert.ToString(number, 2).PadLeft(32, '0')
                           , number);
        }
    }
}

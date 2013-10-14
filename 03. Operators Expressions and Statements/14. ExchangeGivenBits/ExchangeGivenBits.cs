//* Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

using System;
class ExchangeGivenBits
{
    static void Main()
    {
        int number = 0;
        int close = 0;
        int far = 0;
        int k = 0;
        do
        {
            Console.WriteLine("Enter Unsigned Integer number[0-256]:");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("The binary represantation of the number is: \n{0}"
                                , Convert.ToString(number, 2).PadLeft(32, '0'));

            Console.WriteLine("Enter the first position of the bits, that are going to be exchanged:");
            close = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second position of the bits, that are going to be exchanged:");
            far = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of the bits, that are going to be exchanged:");
            k = int.Parse(Console.ReadLine());
        }

        while (!(((close + k) <= 32) && ((far + k) <= 32) && number > 0));

        int mask = (1 << k) - 1;
        int maskClose = mask << close;
        int maskFar = mask << far;

        int closeBits = number & maskClose;
        int farBits = number & maskFar;

        closeBits = closeBits >> close;
        farBits = farBits >> far;

        number = number & (~maskClose);
        number = number & (~maskFar);

        closeBits = closeBits << far;
        farBits = farBits << close;

        number = number | closeBits;
        number = number | farBits;

        Console.WriteLine("number int \n{0}"
                            , Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
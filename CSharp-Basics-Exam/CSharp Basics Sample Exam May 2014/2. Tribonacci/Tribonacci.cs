using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger first = BigInteger.Parse(Console.ReadLine());
        BigInteger second = BigInteger.Parse(Console.ReadLine());
        BigInteger third = BigInteger.Parse(Console.ReadLine());
        BigInteger nElement = BigInteger.Parse(Console.ReadLine());
        BigInteger fourth = first + second + third;

        if (nElement == 1)
        {
            Console.WriteLine(first);
        }
        else if (nElement == 2)
        {
            Console.WriteLine(second);
        }
        else if (nElement == 3)
        {
            Console.WriteLine(third);
        }

        for (int i = 4; i <= nElement; i++)
        {
            first = second;
            second = third;
            third = fourth;
            fourth = first + second + third;

            if (i == nElement)
            {
                Console.WriteLine(third);
            }
        }
    }
}

/*
 * We are given 5 integer numbers. 
 * Write a program that finds all subsets of these numbers whose sum is 0. 
 * Assume that repeating the same subset several times is not a problem.
 */

using System;

class ZeroSubset
{
    static void Main()
    {
        Console.WriteLine("Enter value of the first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of the second number:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of the third number:");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of the fourth number:");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of the fifth number:");
        int e = int.Parse(Console.ReadLine());

        int counter = 0;

        //1 digit check
        if (a == 0)
        {
            counter++;
            Console.WriteLine("{0} = 0", a);
        }
        if (b == 0)
        {
            counter++;
            Console.WriteLine("{0} = 0", b);
        }
        if (c == 0)
        {
            counter++;
            Console.WriteLine("{0} = 0", c);
        }
        if (d == 0)
        {
            counter++;
            Console.WriteLine("{0} = 0", d);
        }
        if (e == 0)
        {
            counter++;
            Console.WriteLine("{0} = 0", e);
        }

        //2 digit check
        if (a + b == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} = 0", a, b);
        }
        if (a + c == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} = 0", a, c);
        }
        if (a + d == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} = 0", a, d);
        }
        if (a + e == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} = 0", a, e);
        }
        if (b + c == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} = 0", b, c);
        }
        if (b + d == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} = 0", b, d);
        }
        if (b + e == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} = 0", b, e);
        }
        if (c + d == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} = 0", c, d);
        }
        if (c + e == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} = 0", c, e);
        }
        if (d + e == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} = 0", d, e);
        }

        //3 digit check
        if (a + b + c == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
        }
        if (a + b + d == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
        }
        if (a + b + e == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
        }
        if (a + c + d == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
        }
        if (a + c + e == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
        }
        if (a + d + e == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
        }
        if (b + c + d == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
        }
        if (b + c + e == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
        }
        if (b + d + e == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
        }
        if (c + d + e == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
        }

        //4 digit check
        if (a + b + c + d == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
        }
        if (a + b + c + e == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
        }
        if (a + b + d + e == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e);
        }
        if (a + c + d + e == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, d, e);
        }
        if (b + c + d + e == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, d, e);
        }

        //5 digit check
        if (a + b + c + d + e == 0)
        {
            counter++;
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
        }

        //Display result
        if (counter >= 1)
        {
            Console.WriteLine("There are {0} subset sums, that are 0"
                                , counter);
        }
        else
        {
            Console.WriteLine("There are none subset sums, that are 0");
        }
    }
}

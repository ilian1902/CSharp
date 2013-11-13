/*
 * Write a program that enters the coefficients a, b and c of a quadratic equation
 * a*x2 + b*x + c = 0
 * and calculates and prints its real roots. 
 * Note that quadratic equations may have 0, 1 or 2 real roots.
 */

using System;
class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter value of a :");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter value of b :");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter value of c :");
        double c = double.Parse(Console.ReadLine());

        double discriminant = (b * b) - 4 * a * c;

        if (a == 0)
        {
            double x1 = -c / b;
            Console.WriteLine("There is one real root: {0}", x1);
        }
        else if (discriminant > 0)
        {
            //if there is only one solution, both x's will be the same
            double discriminantRoot = Math.Sqrt(discriminant);
            double x1 = (-b + discriminantRoot) / (2 * a);
            double x2 = (-b - discriminantRoot) / (2 * a);
            Console.WriteLine(x1 == x2 ?
                                "The Equasion got one real root {0}"
                                : "The Equasion got two real roots {0} {1}"
                                , x1, x2);
        }
        else if (discriminant < 0)
        {
            //There is no solution
            Console.WriteLine("There are no real roots");
        }
    }
}
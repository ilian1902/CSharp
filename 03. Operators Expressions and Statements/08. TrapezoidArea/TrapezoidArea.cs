//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;
class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Enter Trapezoid's side A :");
        decimal a = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter Trapezoid's side B :");
        decimal b = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter Trapezoid's Height:");
        decimal h = decimal.Parse(Console.ReadLine());

        decimal area = (a + b) / 2 * h;

        Console.WriteLine("Trapezoid's Area is: {0}", area);
    }
}
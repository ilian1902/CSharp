﻿/*
 * Write an expression that calculates 
 * trapezoid's area by given sides a and b and height h.
 */

using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Enter Trapezoid's side A :");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Trapezoid's side B :");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Trapezoid's Height:");
        double h = double.Parse(Console.ReadLine());

        double area = (a + b) / 2 * h;

        Console.WriteLine("Trapezoid's Area is: {0}", area);
    }
}

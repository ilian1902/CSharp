/*
 * Write an expression that calculates rectangle’s 
 * perimeter and area by given width and height.
 */

using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Enter rectangle's Width:");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter rectangle's Height:");
        double height = double.Parse(Console.ReadLine());

        double perimeter = (width + height) * 2;
        double area = width * height;

        Console.WriteLine("Perimeter: {0}\nArea: {1}"
                            , perimeter, area);
    }
}

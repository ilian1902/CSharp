//Write an expression that calculates rectangle’s area by given width and height.

using System;
class RectangleArea
{
    static void Main()
    {
        Console.WriteLine("Enter rectangle's Width:");
        decimal width = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter rectangle's Height:");
        decimal height = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Rectangle's Area is :{0}", width * height);
    }
}
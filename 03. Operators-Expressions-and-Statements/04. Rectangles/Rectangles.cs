/*
 * Write an expression that calculates rectangle’s 
 * perimeter and area by given width and height. 
 * Examples:
width	height	perimeter	area
3	    4	    14	        12
2.5	    3	    11	        7.5
5	    5	    20	        25
 */

using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Enter rectangle's Width:");
        decimal width = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter rectangle's Height:");
        decimal height = decimal.Parse(Console.ReadLine());

        decimal perimeter = (width + height) * 2;
        decimal area = width * height;

        Console.WriteLine("Rectangle's perimeter is: {0} and the area is: {1}"
                            , perimeter, area);
    }
}

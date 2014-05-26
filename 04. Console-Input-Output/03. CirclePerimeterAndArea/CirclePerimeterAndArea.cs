/*
 * Write a program that reads the radius r of a circle 
 * and prints its perimeter and area 
 * formatted with 2 digits after the decimal point. 
 * Examples:
r	    perimeter	area
2	    12.57	    12.57
3.5	    21.99	    38.48
 */

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Enter the Circle's radius : ");
        double radius = double.Parse(Console.ReadLine());

        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;

        Console.WriteLine("The perimeter of the Circle is: {0:F2}\nThe Area of the circle is : {1:F2}"
            , perimeter, area);
    }
}

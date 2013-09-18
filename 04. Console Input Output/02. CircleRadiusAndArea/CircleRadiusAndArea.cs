//Write a program that reads the radius r of a circle and prints its perimeter and area.
using System;
class CircleRadiusAndArea
{
    static void Main()
    {
        Console.WriteLine("Enter the Circle's radius : ");
        double radius = double.Parse(Console.ReadLine());

        Console.WriteLine("The perimeter of the Circle is: {0}/nThe Area of the circle is : {1}"
            , 2 * Math.PI * radius, Math.PI * radius * radius);
    }
}
//Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;
class CircleRadiusAndArea
{
    static void Main()
    {
        Console.WriteLine("Enter the Circle's radius : ");
        double radius = double.Parse(Console.ReadLine());

        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;

        Console.WriteLine("The perimeter of the Circle is: {0}/nThe Area of the circle is : {1}"
            , perimeter, area);
    }
}
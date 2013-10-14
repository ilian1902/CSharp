/*
 * Write an expression that checks for given point (x, y) 
 * if it is within the circle K( (1,1), 3) and 
 * out of the rectangle R(top=1, left=-1, width=6, height=2).
 */

using System;
class CheckPointInCircleOutOfRectangle
{
    static void Main()
    {
        double raduis = 3;

        Console.WriteLine("Enter X coordinate");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Y coordinate");
        double y = double.Parse(Console.ReadLine());

        bool isInCircle = (Math.Sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= raduis);
        bool isOutRectangle = ((1 > x || x > 7) && (-1 < y || y < -3));

        if (isInCircle && isOutRectangle)
        {
            Console.WriteLine("The Point is IN the circle and OUT of the rectangle");
        }
        else
        {
            Console.WriteLine("The Point is either OUT of the circle or IN the rectangle");
        }
    }
}
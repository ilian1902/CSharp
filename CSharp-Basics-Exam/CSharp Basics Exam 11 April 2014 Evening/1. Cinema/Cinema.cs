using System;

class Cinema
{
    static void Main()
    {
        string projection = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());
        double income = rows * columns;

        if (projection.Equals("Premiere"))
        {
            Console.WriteLine("{0:0.00} leva", income * 12.00);
        }
        if (projection.Equals("Normal"))
        {
            Console.WriteLine("{0:0.00} leva", income * 7.50);
        }
        if (projection.Equals("Discount"))
        {
            Console.WriteLine("{0:0.00} leva", income * 5.00);
        }
    }
}

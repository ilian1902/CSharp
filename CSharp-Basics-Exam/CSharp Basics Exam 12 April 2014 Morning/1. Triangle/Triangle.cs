using System;

class Triangle
{
    static void Main()
    {
        double Ax = double.Parse(Console.ReadLine());
        double Ay = double.Parse(Console.ReadLine());
        double Bx = double.Parse(Console.ReadLine());
        double By = double.Parse(Console.ReadLine());
        double Cx = double.Parse(Console.ReadLine());
        double Cy = double.Parse(Console.ReadLine());

        double ab = Math.Sqrt((Bx - Ax) * (Bx - Ax) + (By - Ay) * (By - Ay));
        double bc = Math.Sqrt((Cx - Bx) * (Cx - Bx) + (Cy - By) * (Cy - By));
        double ca = Math.Sqrt((Ax - Cx) * (Ax - Cx) + (Ay - Cy) * (Ay - Cy));

        if (ab + bc > ca && bc + ca > ab && ca + ab > bc)
        {
            double p = (ab + bc + ca) / 2;
            double area = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ca));
            Console.WriteLine("Yes\n{0:0.00}", area);
        }
        else
        {
            Console.WriteLine("No\n{0:0.00}", ab);
        }
    }
}

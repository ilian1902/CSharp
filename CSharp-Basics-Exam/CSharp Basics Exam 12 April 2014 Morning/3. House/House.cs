using System;
using System.Text;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        StringBuilder roof = new StringBuilder();
        StringBuilder storeys = new StringBuilder();
        char dot = '.';
        char asterisk = '*';
        roof.Append(dot, n / 2);
        roof.Append(asterisk, 1);
        roof.Append(dot, n / 2);
        roof.Append("\n");
        for (int i = n / 2 - 1, inner = 1; i > 0 / 2; i--, inner += 2)
        {
            roof.Append(dot, i);
            roof.Append(asterisk, 1);
            roof.Append(dot, inner);
            roof.Append(asterisk, 1);
            roof.Append(dot, i);
            roof.Append("\n");
        }
        roof.Append(asterisk, n);
        roof.Append("\n");

        for (int i = n / 2 - 1; i > 0; i--)
        {
            storeys.Append(dot, n / 4);
            storeys.Append(asterisk, 1);
            storeys.Append(dot, n - (n / 4) * 2 - 2);
            storeys.Append(asterisk, 1);
            storeys.Append(dot, n / 4);
            storeys.Append("\n");
        }
        storeys.Append(dot, n / 4);
        storeys.Append(asterisk, n - (n / 4) * 2);
        storeys.Append(dot, n / 4);
        storeys.Append("\n");
        Console.WriteLine("{0}{1}", roof, storeys);
    }
}

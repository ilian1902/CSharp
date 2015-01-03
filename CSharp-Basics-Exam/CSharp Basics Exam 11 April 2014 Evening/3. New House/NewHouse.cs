using System;
using System.Text;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char dash = '-';
        char asterisk = '*';
        char pipe = '|';
        StringBuilder roof = new StringBuilder();
        StringBuilder mid = new StringBuilder();
        StringBuilder storeys = new StringBuilder();

        for (int i = n / 2, r = 1; i > 0; i--, r += 2)
        {
            roof.Append(dash, i);
            roof.Append(asterisk, r);
            roof.Append(dash, i);
            roof.Append("\n");
        }
        mid.Append(asterisk, n);
        for (int i = 0; i < n; i++)
        {
            storeys.Append(pipe, 1);
            storeys.Append(asterisk, n - 2);
            storeys.Append(pipe, 1);
            storeys.Append("\n");
        }
        Console.WriteLine("{0}{1}\n{2}", roof, mid, storeys);

    }
}

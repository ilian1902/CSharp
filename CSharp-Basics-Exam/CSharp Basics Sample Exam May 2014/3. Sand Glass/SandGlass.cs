using System;
using System.Text;

class SandGlass
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        char dot = '.';
        char asterisk = '*';
        int dotNumber = 0;
        int asteriskNumber = 0;
        StringBuilder fig = new StringBuilder();
        for (int i = 0; i < rows / 2; i++)
        {
            dotNumber = i;
            asteriskNumber = rows - 2 * dotNumber;

            fig.Append(dot, dotNumber);
            fig.Append(asterisk, asteriskNumber);
            fig.Append(dot, dotNumber);
            fig.Append("\n");
        }
        for (int i = rows / 2; i >= 0; i--)
        {
            dotNumber = i;
            asteriskNumber = rows - 2 * dotNumber;

            fig.Append(dot, dotNumber);
            fig.Append(asterisk, asteriskNumber);
            fig.Append(dot, dotNumber);
            fig.Append("\n");
        }
        Console.WriteLine(fig);
    }
}

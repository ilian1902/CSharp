using System;
using System.Text;

class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        StringBuilder result = new StringBuilder();

        char diamond = '*';
        char space = '-';
        int counter = n / 2 - 1;
        //Upper Half
        Console.WriteLine("{0}{1}{2}", new string(space, n / 2), diamond, new string(space, n / 2));
        for (int i = counter, inner = 1; i > 0; i--, inner += 2)
        {
            result.Append(space, i);
            result.Append(diamond, 1);
            result.Append(space, inner);
            result.Append(diamond, 1);
            result.Append(space, i);
            result.Append("\n");
        }
        //lower Half
        for (int i = 0, inner = n - 2; i <= counter; i++, inner -= 2)
        {
            result.Append(space, i);
            result.Append(diamond, 1);
            result.Append(space, inner);
            result.Append(diamond, 1);
            result.Append(space, i);
            result.Append("\n");
        }
        Console.Write(result);
        Console.WriteLine("{0}{1}{2}", new string(space, n / 2), diamond, new string(space, n / 2));
    }
}

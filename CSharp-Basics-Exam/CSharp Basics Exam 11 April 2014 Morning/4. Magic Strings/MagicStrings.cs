using System;
using System.Collections.Generic;

class MagicStrings
{
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        char[] chars = { 's', 'n', 'k', 'p' };
        int[] weights = { 3, 4, 1, 5 };
        bool hasMatch = false;
        List<string> results = new List<string>();

        for (int a = 0; a < 4; a++)
        {
            for (int b = 0; b < 4; b++)
            {
                for (int c = 0; c < 4; c++)
                {
                    for (int d = 0; d < 4; d++)
                    {
                        for (int e = 0; e < 4; e++)
                        {
                            for (int f = 0; f < 4; f++)
                            {
                                for (int g = 0; g < 4; g++)
                                {
                                    for (int h = 0; h < 4; h++)
                                    {
                                        int firstHalf = weights[a] + weights[b] + weights[c] + weights[d];
                                        string first = "" + chars[a] + chars[b] + chars[c] + chars[d];
                                        int secondHalf = weights[e] + weights[f] + weights[g] + weights[h];
                                        string last = "" + chars[e] + chars[f] + chars[g] + chars[h];

                                        if (Math.Abs(firstHalf - secondHalf) == diff)
                                        {
                                            results.Add(first + last);
                                            hasMatch = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (!hasMatch)
        {
            Console.WriteLine("No");
        }
        else
        {
            results.Sort();
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}

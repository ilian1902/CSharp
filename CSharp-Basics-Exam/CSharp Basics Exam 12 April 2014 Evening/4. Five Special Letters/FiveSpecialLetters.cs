using System;
using System.Collections.Generic;

class FiveSpecialLetters
{
    static void Main()
    {
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        bool isFound = false;
        for (char a = 'a'; a < 'e'; a++)
        {
            for (char b = 'a'; b < 'e'; b++)
            {
                for (char c = 'a'; c < 'e'; c++)
                {
                    for (char d = 'a'; d < 'e'; d++)
                    {
                        for (char e = 'a'; e < 'e'; e++)
                        {
                            string word = "" + a + b + c + d + e;
                            int currentValue = 0;
                            List<Char> chars = new List<Char>();
                            for (int i = 0; i < word.Length; i++)
                            {
                                if (!chars.Contains(word[i]))
                                {
                                    chars.Add(word[i]);
                                }
                            }

                            for (int ch = 0; ch < chars.Count; ch++)
                            {
                                switch (chars[ch])
                                {
                                    case 'a': currentValue += (ch + 1) * 5;
                                        break;
                                    case 'b': currentValue += (ch + 1) * -12;
                                        break;
                                    case 'c': currentValue += (ch + 1) * 47;
                                        break;
                                    case 'd': currentValue += (ch + 1) * 7;
                                        break;
                                    case 'e': currentValue += (ch + 1) * -32;
                                        break;

                                    default:
                                        break;
                                }

                            }


                            if (currentValue >= min && currentValue <= max)
                            {
                                Console.WriteLine("{0} ", word);
                                isFound = true;
                            }
                        }
                    }
                }
            }
        }
        if (!isFound)
        {
            Console.WriteLine("No");
        }
    }
}

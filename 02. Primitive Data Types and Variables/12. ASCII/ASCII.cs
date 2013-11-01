/*
 *Write a program that prints the entire ASCII table of characters on the console.
 */

using System;
using System.Text;
class ASCII
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        for (int code = 0; code <= 255; code++)
        {
            char symbol = (char)code;
            Console.WriteLine("{0,3} {1}"
                                , code, symbol);
        }
    }
}
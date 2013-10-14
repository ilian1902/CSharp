/*
 * Declare a character variable 
 * and assign it with the symbol that has Unicode code 72.
 */

using System;
class DeclareChar
{
    static void Main()
    {
        char symbol = '\u0048';
        Console.WriteLine("The symbol that has Unicode code {0} is {1}"
                            , (int)symbol, symbol);
    }
}
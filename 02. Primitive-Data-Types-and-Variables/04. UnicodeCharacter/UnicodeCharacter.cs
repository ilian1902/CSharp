/*
 * Declare a character variable and assign it with 
 * the symbol that has Unicode code 42 (decimal) using the '\u00XX' syntax, 
 * and then print it. 
 * Hint: The output should be “*”.
 */

using System;

class UnicodeCharacter
{
    static void Main()
    {
        char symbol = '\u002A';
        Console.WriteLine("The symbol that has Unicode code {0} is {1}"
                            , (int)symbol, symbol);
    }
}

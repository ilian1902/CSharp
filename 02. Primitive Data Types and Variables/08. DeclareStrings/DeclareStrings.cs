/*
 * Declare two string variables and assign them with following value:
 * "The "use" of quotations causes difficulties."
 * Do the above in two different ways: with and without using quoted strings.
 */

using System;
class DeclareStrings
{
    static void Main()
    {
        string escaped = "The \"use\" of quotations causes difficulties.";
        string quoted = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(escaped);
        Console.WriteLine(quoted);
    }
}
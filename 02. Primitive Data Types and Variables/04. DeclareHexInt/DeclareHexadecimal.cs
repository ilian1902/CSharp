/*
 * Declare an integer variable and assign it 
 * with the value 254 in hexadecimal format.
 */

using System;
class DeclareHexInt
{
    static void Main()
    {

        int number = 0xFE;

        Console.WriteLine("{0} in hexadecimal format is : {1:X}"
                                        , number, number);
    }
}
//Declare an integer variable and assign it 
//with the value 254 in hexadecimal format.
using System;
class DeclareHexInt
{
    static void Main()
    {
        int хNumber = 0xFE;
        int number = 254;

        Console.WriteLine("{0} In hexadecimal format is : {1:X}", number, хNumber);
    }
}
//Write an expression that extracts from a given integer i the value of a given bit number b.

using System;
class ExtractBitValue
{
    static void Main()
    {
        Console.WriteLine("Enter an Integer Number:");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit's position:");
        int b = int.Parse(Console.ReadLine());

        int bitChecker = 1;
        int check = ((i >> b) & bitChecker);

        Console.WriteLine("The bit on position {0} has value of: {1}"
                            , b, ((check & bitChecker) != 0 ? 1 : 0));
    }
}